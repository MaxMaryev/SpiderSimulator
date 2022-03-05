using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody), typeof(SphereCollider))]
public class ButterFly : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _requaredWebForCocoon;
    [SerializeField] private GameObject _cocoonPrefab;

    private Rigidbody _rigidbody;
    private float _cocoonStage;

    public float CocoonStage => _cocoonStage;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(Vector3.forward * _force, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<DeadZone>(out DeadZone deadZone))
            Destroy(gameObject);
    }

    public void TryDoBreakthrough()
    {
        _rigidbody.AddForce(Vector3.forward * _force, ForceMode.Impulse);
    }

    public void BecomeCocoon(float spiderWeb)
    {
        _cocoonStage = spiderWeb/_requaredWebForCocoon;
        SlowDown(_cocoonStage);

        if (spiderWeb >= _requaredWebForCocoon)
        {
            Instantiate(_cocoonPrefab, transform.position, Quaternion.identity);
            StartCoroutine(Destroy());
        }
    }

    private IEnumerator Destroy()
    {
        float delay = 0.1f;

        GetComponent<SphereCollider>().radius = 0;
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }

    private void SlowDown(float cocoonStage)
    {
        _rigidbody.velocity *= 1 - cocoonStage;
    }
}
