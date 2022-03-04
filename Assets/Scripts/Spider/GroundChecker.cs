using UnityEngine;
using System.Linq;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private float _rayDistance;
    [SerializeField] private float _rayCircleRadius;

    private Transform _transform;
    private bool _isGrounded;
    private Vector3[] _points = new Vector3[6];
    private RaycastHit[] _hits = new RaycastHit[6];

    public bool IsGrounded => _isGrounded;

    private void Awake()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        CheckByRaycasts();

        SetGroundedState();
    }

    private void SetGroundedState()
    {
        if (_hits.Any(hit => hit.collider != null))
            _isGrounded = true;
        else
            _isGrounded = false;
    }

    private void CheckByRaycasts()
    {
        for (int i = 0; i < _points.Length; i++)
        {
            float x = _rayCircleRadius * Mathf.Cos(((float)i + 1 / _points.Length));
            float y = 0;
            float z = _rayCircleRadius * Mathf.Sin(((float)i + 1 / _points.Length));

            _points[i] = _transform.position + _transform.InverseTransformDirection(new Vector3(x, y, z));

            //Debug.DrawRay(_points[i], -transform.up * _rayDistance, Color.red);
            Physics.Raycast(_points[i], -_transform.up, out _hits[i], _rayDistance);
        }
    }
}
