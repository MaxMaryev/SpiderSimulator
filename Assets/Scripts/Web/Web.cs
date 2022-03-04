using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Web : MonoBehaviour
{
    [SerializeField] private float _rayDistanse = 1;
    [SerializeField] private float _forceValue = 10;
    [SerializeField] private int _stickTime = 10;
    [SerializeField] private float _timeWindowForVictimEscape = 0.7f;

    private Rigidbody _rigidbody;
    private Transform _transform;
    private Coroutine _stickVictim;
    private RaycastHit hitForward;
    private RaycastHit hitBack;
    private RaycastHit hitRight;
    private RaycastHit hitLeft;
    private Vector3 _forwardSphere;
    private Vector3 _backSphere;
    private Vector3 _rightSphere;
    private Vector3 _leftSphere;
    private float _forceUp;
    private float _forceDown;
    private float _forceRight;
    private float _forceLeft;
    private bool _isCatched;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _transform = GetComponent<Transform>();

        if (Physics.Raycast(_transform.position, _transform.forward, out hitForward, _rayDistanse))
            _forwardSphere = hitForward.transform.position;

        if (Physics.Raycast(_transform.position, -_transform.forward, out hitBack, _rayDistanse))
            _backSphere = hitBack.transform.position;

        if (Physics.Raycast(_transform.position, _transform.right, out hitRight, _rayDistanse))
            _rightSphere = hitRight.transform.position;

        if (Physics.Raycast(_transform.position, -_transform.right, out hitLeft, _rayDistanse))
            _leftSphere = hitLeft.transform.position;
    }

    private void Update()
    {
        _rigidbody.AddForce((_transform.position - _forwardSphere).normalized * -_forceUp);
        _rigidbody.AddForce((_transform.position - _backSphere).normalized * -_forceDown);
        _rigidbody.AddForce((_transform.position - _rightSphere).normalized * -_forceRight);
        _rigidbody.AddForce((_transform.position - _leftSphere).normalized * -_forceLeft);

        _forceUp = Vector3.Distance(_transform.position, hitForward.point) * _forceValue;
        _forceDown = Vector3.Distance(_transform.position, hitBack.point) * _forceValue;
        _forceRight = Vector3.Distance(_transform.position, hitForward.point) * _forceValue;
        _forceLeft = Vector3.Distance(_transform.position, hitBack.point) * _forceValue;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (_isCatched)
            return;

        if (collision.gameObject.GetComponent<ButterFly>())
        {
            _stickVictim = StartCoroutine(TryStickVictim(collision.gameObject));
        }
    }

    private IEnumerator TryStickVictim(GameObject victim)
    {
        _isCatched = true;
        gameObject.AddComponent<HingeJoint>();
        GetComponent<HingeJoint>().connectedBody = victim.GetComponent<Rigidbody>();

        yield return new WaitForSeconds(_stickTime);

        Destroy(GetComponent<HingeJoint>());
        yield return new WaitForSeconds(_timeWindowForVictimEscape);

        if (victim != null)
            victim.GetComponent<ButterFly>().TryDoBreakthrough();

        yield return new WaitForSeconds(_timeWindowForVictimEscape);
        _isCatched = false;
    }
}
