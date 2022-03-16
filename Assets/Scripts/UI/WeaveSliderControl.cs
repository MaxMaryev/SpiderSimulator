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
    private float _soundRepeatDelay = 0.6f;
    private WaitForSeconds _delayedDeltaMeasuring;
    private WaitForSeconds _delayedSoundRepeating;

    public float Delta { get; private set; }

    private void Awake()
    {
        _particleSystem.Stop();
        _slider = GetComponent<Slider>();
        _audioSource = GetComponent<AudioSource>();
        _delayedDeltaMeasuring = new WaitForSeconds(_deltaMeasuringDelay);
        _delayedSoundRepeating = new WaitForSeconds(_soundRepeatDelay);
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
            yield return _delayedDeltaMeasuring;
            Delta = Mathf.Abs(_previousSliderValue - _slider.value);
        }

        Delta = 0;
    }

    private IEnumerator PlaySound()
    {
        while (_isWearing)
        {
            _audioSource.PlayOneShot(_weaveSound);
            yield return _delayedSoundRepeating;
        }
    }
}
