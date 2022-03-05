using UnityEngine;
using System.Linq;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private float _rayDistance;
    [SerializeField] private float _rayCircleRadius;

    private Vector3[] _points = new Vector3[6];
    private RaycastHit[] _hits = new RaycastHit[6];

    public bool IsGrounded { get; private set; }

    private void Update()
    {
        EmitRaycasts();

        SetGroundedState();
    }

    private void SetGroundedState()
    {
        IsGrounded = _hits.Any(hit => hit.collider != null);
    }

    private void EmitRaycasts()
    {
        for (int i = 0; i < _points.Length; i++)
        {
            float x = _rayCircleRadius * Mathf.Cos(((float)i + 1 / _points.Length));
            float y = 0;
            float z = _rayCircleRadius * Mathf.Sin(((float)i + 1 / _points.Length));

            _points[i] = transform.position + transform.InverseTransformDirection(new Vector3(x, y, z));

            //Debug.DrawRay(_points[i], -transform.up * _rayDistance, Color.red);
            Physics.Raycast(_points[i], -transform.up, out _hits[i], _rayDistance);
        }
    }
}
