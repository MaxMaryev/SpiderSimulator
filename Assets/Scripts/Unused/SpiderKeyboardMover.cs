using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(GroundChecker))]
public class SpiderKeyboardMover : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private GroundChecker _groundChecker;
    [SerializeField] private float _legSticknessForce;

    private InputControl _inputControl;
    private Animator _animator;
    private Rigidbody _rigidbody;
    private float _currentSticknessForce;
    private float _maxSticknessForce;

    private string _left = "Left";
    private string _right = "Right";
    private string[] _legPairs = new string[4] { "_1", "_2", "_3", "_4" };
    private string _legForthState = "_Forth";
    private string _legBackState = "_Back";


    private void Awake()
    {
        int legsCount = 2 * _legPairs.Length;

        _maxSticknessForce = legsCount * _legSticknessForce;
        _currentSticknessForce = _maxSticknessForce;
        _inputControl = new InputControl();
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();

        _inputControl.Spider.Left1.performed += ctx => OnLegMovesBack($"{_left + _legPairs[0]}");
        _inputControl.Spider.Left2.performed += ctx => OnLegMovesBack($"{_left + _legPairs[1]}");
        _inputControl.Spider.Left3.performed += ctx => OnLegMovesBack($"{_left + _legPairs[2]}");
        _inputControl.Spider.Left4.performed += ctx => OnLegMovesBack($"{_left + _legPairs[3]}");
        _inputControl.Spider.Right1.performed += ctx => OnLegMovesBack($"{_right + _legPairs[0]}");
        _inputControl.Spider.Right2.performed += ctx => OnLegMovesBack($"{_right + _legPairs[1]}");
        _inputControl.Spider.Right3.performed += ctx => OnLegMovesBack($"{_right + _legPairs[2]}");
        _inputControl.Spider.Right4.performed += ctx => OnLegMovesBack($"{_right + _legPairs[3]}");

        _inputControl.Spider.Left1.started += ctx => OnLegMovesFoward($"{_left + _legPairs[0]}");
        _inputControl.Spider.Left2.started += ctx => OnLegMovesFoward($"{_left + _legPairs[1]}");
        _inputControl.Spider.Left3.started += ctx => OnLegMovesFoward($"{_left + _legPairs[2]}");
        _inputControl.Spider.Left4.started += ctx => OnLegMovesFoward($"{_left + _legPairs[3]}");
        _inputControl.Spider.Right1.started += ctx => OnLegMovesFoward($"{_right + _legPairs[0]}");
        _inputControl.Spider.Right2.started += ctx => OnLegMovesFoward($"{_right + _legPairs[1]}");
        _inputControl.Spider.Right3.started += ctx => OnLegMovesFoward($"{_right + _legPairs[2]}");
        _inputControl.Spider.Right4.started += ctx => OnLegMovesFoward($"{_right + _legPairs[3]}");
    }

    private void Update()
    {
        if (!_groundChecker.IsGrounded)
        {
            _rigidbody.useGravity = true;
            return;
        }

        Stick();
    }

    private void OnEnable()
    {
        _inputControl.Enable();
    }

    private void OnDisable()
    {
        _inputControl.Disable();
    }

    private void OnLegMovesFoward(string leg)
    {
        _animator.SetTrigger(leg + _legForthState);

        _currentSticknessForce -= _legSticknessForce;
    }

    private void OnLegMovesBack(string leg)
    {
        _animator.SetTrigger(leg + _legBackState);

        _currentSticknessForce += _legSticknessForce;

        if (_groundChecker.IsGrounded)
        {
            StartCoroutine(MoveFoward());
            StartCoroutine(Rotate(leg));
        }
    }

    private void Stick()
    {
        _rigidbody.useGravity = false;
        _rigidbody.velocity = -transform.up * _currentSticknessForce;
    }

    private IEnumerator Rotate(string leg)
    {
        int turningSide = 1;
        int iterationsCount = 30;

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
            transform.Translate(transform.forward * _moveSpeed, Space.World);
            yield return null;
        }
    }
}
