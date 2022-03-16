using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Rigidbody), typeof(GroundChecker))]
[RequireComponent(typeof(Spider))]
public class SpiderMover : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _stickForce;
    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private MoveButtonControl[] _moveButtons;

    private Animator _animator;
    private Rigidbody _rigidbody;
    private Spider _spider;

    private string _right = "Right";
    private string[] _legPairs = new string[4] { "_1", "_2", "_3", "_4" };
    private string[] _legMoveDirections = { "_Forth", "_Back" };

    private void Awake()
    {
        int legsCount = 2 * _legPairs.Length;

        _spider = GetComponent<Spider>();
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();

        foreach (var moveButton in _moveButtons)
        {
            moveButton.PressedEvent += MoveLegFoward;
            moveButton.UnpressedEvent += MoveLegBack;
        }

        _spider.GrowEvent += ImproveSpeed;
    }

    private void Update()
    {
        if (!_groundChecker.IsGrounded || !_spider.IsAlive)
        {
            _rigidbody.useGravity = true;
            return;
        }

        Stick();
    }

    private void OnDisable()
    {
        foreach (var moveButton in _moveButtons)
        {
            moveButton.PressedEvent -= MoveLegFoward;
            moveButton.UnpressedEvent -= MoveLegBack;
        }

        _spider.GrowEvent -= ImproveSpeed;
    }

    private void MoveLegFoward(string leg)
    {
        _animator.SetTrigger(leg + _legMoveDirections[0]);
    }

    private void MoveLegBack(string leg)
    {
        _animator.SetTrigger(leg + _legMoveDirections[1]);

        if (_groundChecker.IsGrounded)
        {
            StartCoroutine(MoveFoward());
            StartCoroutine(Rotate(leg));
        }
    }

    private void Stick()
    {
        _rigidbody.useGravity = false;
        _rigidbody.velocity = -base.transform.up * _stickForce;
    }

    private IEnumerator Rotate(string leg)
    {
        int turningSide = 1;
        int iterationsCount = 20;

        if (leg.Contains(_right))
            turningSide = -turningSide;

        for (int i = 0; i < iterationsCount; i++)
        {
            transform.Rotate(Vector3.up, _rotationSpeed * turningSide, Space.Self);
            yield return null;
        }
    }

    private IEnumerator MoveFoward()
    {
        int iterationsCount = 20;

        for (int i = 0; i < iterationsCount; i++)
        {
            transform.Translate(Vector3.forward * _moveSpeed, Space.Self);
            yield return null;
        }
    }

    private void ImproveSpeed(float growStep)
    {
        _moveSpeed *= growStep;
    }
}
