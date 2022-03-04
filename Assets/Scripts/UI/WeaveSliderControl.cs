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
    private float _delta;
    private bool _isWearing;

    public float Delta => _delta;

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
        _setDelta = StartCoroutine(SetDelta());
        _playSound = StartCoroutine(PlaySound());
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _isWearing = false;

        StopCoroutine(_setDelta);
        StopCoroutine(_playSound);
    }

    private IEnumerator SetDelta()
    {
        bool isDragging = true;

        while (isDragging)
        {
            _previousSliderValue = _slider.value;
            yield return new WaitForSeconds(Time.deltaTime);
            _delta = Mathf.Abs(_previousSliderValue - _slider.value);
        }
    }

    private IEnumerator PlaySound()
    {
        _isWearing = true;
        float delayBetweenPlays = 0.6f;

        while (_isWearing)
        {
            _audioSource.PlayOneShot(_weaveSound);
            yield return new WaitForSeconds(delayBetweenPlays);
        }
    }
}
