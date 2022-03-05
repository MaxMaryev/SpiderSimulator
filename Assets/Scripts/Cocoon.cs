using UnityEngine;
using System.Collections;
using System.Linq;
using DG.Tweening;

public class Cocoon : MonoBehaviour
{
    [SerializeField] private int _nutrition = 100;

    private Sequence _sequence;

    public int Nutrition => _nutrition;
    public bool IsMoving { get; private set; }

    private void Awake()
    {
        _sequence = DOTween.Sequence();
        IsMoving = true;
    }

    private void Start()
    {
        float scaleIncrease = 0.2f;
        float yScaleIncrease = 0.1f;
        float changeScaleSpeed = 0.3f;
        int loopsNumber = 5;

        ConnectToWeb();

        _sequence.Append(transform.DOScaleX(transform.localScale.x + scaleIncrease, changeScaleSpeed));
        _sequence.Append(transform.DOScaleX(transform.localScale.x, changeScaleSpeed));
        _sequence.Append(transform.DOScaleZ(transform.localScale.z + scaleIncrease, changeScaleSpeed));
        _sequence.Append(transform.DOScaleZ(transform.localScale.z, changeScaleSpeed));
        _sequence.Append(transform.DOScaleY(transform.localScale.y + yScaleIncrease, changeScaleSpeed));
        _sequence.Append(transform.DOScaleY(transform.localScale.y, changeScaleSpeed));
        _sequence.SetLoops(loopsNumber, LoopType.Yoyo).OnKill(() => IsMoving = false);
    }

    public IEnumerator BeEaten(Vector3 mouth)
    {
        float duration = 1;

        transform.DOScale(0, duration);
        transform.DOMove(mouth, duration);

        yield return new WaitForSeconds(duration);

        Destroy(gameObject);
    }


    private void Update()
    {
        Debug.DrawRay(transform.position, -transform.forward * 5, Color.red);
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red);
    }

    private void ConnectToWeb()
    {
        RaycastHit[] hits = new RaycastHit[6];
        EmitRaycasts();
        bool hasHit = hits.Any(hit => hit.collider != null);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hasHit && hits[i].collider.TryGetComponent<Web>(out Web web))
            {
                if (i < hits.Length / 2)
                    transform.position = hits[i].point - transform.forward;
                else
                    transform.position = hits[i].point + transform.forward;

                break;
            }
        }

        void EmitRaycasts()
        {
            int rayDistance = 5;

            Physics.Raycast(transform.position, transform.forward, out hits[0], rayDistance);
            Physics.Raycast(transform.position + transform.up, transform.forward, out hits[1], rayDistance);
            Physics.Raycast(transform.position - transform.up, transform.forward, out hits[2], rayDistance);
            Physics.Raycast(transform.position, -transform.forward, out hits[3], rayDistance);
            Physics.Raycast(transform.position + transform.up, -transform.forward, out hits[4], rayDistance);
            Physics.Raycast(transform.position - transform.up, -transform.forward, out hits[5], rayDistance);
        }
    }
}
