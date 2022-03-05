using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HungerSlider : MonoBehaviour
{
    [SerializeField] private Spider _spider;
    [SerializeField] private Image _fill;

    private Slider _slider;
    private Color _startColor;
    private Coroutine _sliderValue;
    private Coroutine _sliderColor;
    private float _updatingDelay = 0.4f;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _spider.Hunger;
        _slider.value = _slider.maxValue;
        _startColor = _fill.color;
    }

    private void Start()
    {
        _sliderValue = StartCoroutine(UpdatingSliderValue());
        _sliderColor = StartCoroutine(UdpatingSliderColor());
    }

    private void OnDisable()
    {
        if (_sliderValue != null)
            StopCoroutine(_sliderValue);

        if (_sliderColor != null)
            StopCoroutine(_sliderColor);
    }

    private IEnumerator UpdatingSliderValue()
    {
        while (_slider.value != 0)
        {
            _slider.value = _spider.Hunger;
            yield return new WaitForSeconds(_updatingDelay);
        }
    }

    private IEnumerator UdpatingSliderColor()
    {
        while (_slider.value != 0)
        {
            float normilizedFloat = (_slider.maxValue - _slider.value) / _slider.maxValue;
            _fill.color = Color.Lerp(_startColor, Color.red, normilizedFloat);
            yield return new WaitForSeconds(_updatingDelay);
        }
    }
}
