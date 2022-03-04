using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Rigidbody))]
public class WingAnimator : MonoBehaviour
{
    [SerializeField] private int _rotateAngle;
    [SerializeField] private float _rotateSpeed = 0.2f;

    private Rigidbody _rigidbody;
    private Sequence _sequence;

    private void Awake()
    {
        _sequence = DOTween.Sequence();
        _rigidbody = GetComponent<Rigidbody>();

        _sequence.Append(_rigidbody.DORotate(Vector3.down * _rotateAngle, _rotateSpeed, RotateMode.LocalAxisAdd));
        _sequence.Append(_rigidbody.DORotate(Vector3.up * _rotateAngle, _rotateSpeed, RotateMode.LocalAxisAdd));
        _sequence.SetLoops(-1, LoopType.Yoyo);
    }

    private void OnDestroy()
    {
        _sequence.Kill();
    }
}
