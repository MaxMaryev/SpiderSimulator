using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Cocoon : MonoBehaviour
{
    [SerializeField] private int _nutrition = 100;

    private Transform _transform;
    private Sequence _sequence;
    private CapsuleCollider _collider;
    private float _defaultColliderRadius;
    private bool _isMoving = true;

    public int Nutrition => _nutrition;
    public bool IsMoving => _isMoving;

    private void Awake()
    {
        _collider = GetComponent<CapsuleCollider>();
        _transform = GetComponent<Transform>();
        _sequence = DOTween.Sequence();
        _defaultColliderRadius = _collider.radius;
    }

    private void Start()
    {
        float scaleIncrease = 0.2f;
        float yScaleIncrease = 0.1f;
        float changeScaleSpeed = 0.3f;
        int loopsNumber = 5;

        _sequence.Append(_transform.DOScaleX(_transform.localScale.x + scaleIncrease, changeScaleSpeed));
        _sequence.Append(_transform.DOScaleX(_transform.localScale.x, changeScaleSpeed));
        _sequence.Append(_transform.DOScaleZ(_transform.localScale.z + scaleIncrease, changeScaleSpeed));
        _sequence.Append(_transform.DOScaleZ(_transform.localScale.z, changeScaleSpeed));
        _sequence.Append(_transform.DOScaleY(_transform.localScale.y + yScaleIncrease, changeScaleSpeed));
        _sequence.Append(_transform.DOScaleY(_transform.localScale.y, changeScaleSpeed));
        _sequence.SetLoops(loopsNumber, LoopType.Yoyo).OnKill(() => _isMoving = false);
    }

    public IEnumerator BeEaten(Vector3 mouth)
    {
        float duration = 1;

        _transform.DOScale(0, duration);
        _transform.DOMove(mouth, duration);

        yield return new WaitForSeconds(duration);

        Destroy(gameObject);
    }
}
