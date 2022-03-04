using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody), typeof(AudioSource))]
public class Spider : MonoBehaviour
{
    public UnityAction GameOver;

    [SerializeField] private float _hunger = 100;
    [SerializeField] private float _hungerSpeed = 1;
    [SerializeField] private Transform _mouth;
    [SerializeField] private AudioClip _eatSound;
    [SerializeField] private float _growStep = 1.1f;
    [SerializeField] private float _speedRaise = 0.75f;

    private bool _isEating = false;
    private bool _isAlive = true;
    private AudioSource _audioSource;

    public float Hunger => _hunger;
    public bool IsAlive => _isAlive;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (_hunger < 0)
        {
            _hunger = 0;
            Die();
        }
        else if (_hunger > 0)
        {
            _hunger -= Time.deltaTime * _hungerSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<DeadZone>(out DeadZone spiderDeadZone))
            Die();

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<Cocoon>(out Cocoon cocoon) && !cocoon.IsMoving && _isEating == false)
        {
            Eat(cocoon);
            StartCoroutine(SetIsEatingFalse(other));
            Grow();
        }
    }

    private void Eat(Cocoon cocoon)
    {
        float maxValue = 100;
        _isEating = true;

        _audioSource.PlayOneShot(_eatSound);
        StartCoroutine(cocoon.BeEaten(_mouth.position));

        _hunger += cocoon.Nutrition;

        if (_hunger > maxValue)
            _hunger = maxValue;
    }

    private IEnumerator SetIsEatingFalse(Collider cocoon)
    {
        yield return new WaitUntil(() => cocoon == null);
        _isEating = false;
    }

    private void Grow()
    {
        transform.localScale *= _growStep;
        _hungerSpeed += _speedRaise;
    }

    private void Die()
    {
        _isAlive = false;
        GameOver?.Invoke();
    }
}
