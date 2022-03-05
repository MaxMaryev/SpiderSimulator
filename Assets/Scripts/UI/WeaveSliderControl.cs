using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Slider), typeof(AudioSource))]
public class WeaveSliderControl : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Animator _spiderAnimator;
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private AudioClip _weaveSound;

    private AudioSource _audioSource;
    private Slider _slider;
    private Coroutine _setDelta;
    private Coroutine _playSound;
    private float _previousSliderValue;
    private bool _isWearing;
    private float _deltaMeasuringDelay = 0.2f;

    public float Delta { get; private set; }

    private void Awake()
    {
        _particleSystem.Stop();
        _slider = GetComponent<Slider>();
        _audioSource = GetComponent<AudioSource>();
    }

    public void ControlAnimation()
    {
        _spiderAnimator.SetFloat(_slider.name, _slider.value);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _isWearing = true;
        _setDelta = StartCoroutine(SetDelta());
        _playSound = StartCoroutine(PlaySound());
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _isWearing = false;
    }

    private void OnDisable()
    {
        if (_setDelta != null)
            StopCoroutine(_setDelta);

        if (_playSound != null)
            StopCoroutine(_playSound);
    }
    private IEnumerator SetDelta()
    {
        while (_isWearing)
        {
            _previousSliderValue = _slider.value;
            yield return new WaitForSeconds(_deltaMeasuringDelay);
            Delta = Mathf.Abs(_previousSliderValue - _slider.value);
        }

        Delta = 0;
    }

    private IEnumerator PlaySound()
    {
        float delayBetweenPlays = 0.6f;

        while (_isWearing)
        {
            _audioSource.PlayOneShot(_weaveSound);
            yield return new WaitForSeconds(delayBetweenPlays);
        }
    }
}
