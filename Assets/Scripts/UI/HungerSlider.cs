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

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _spider.Hunger;
        _slider.value = _slider.maxValue;
        _startColor = _fill.color;
    }

    private void Update()
    {
        float normilizedFloat = (_slider.maxValue - _slider.value) / _slider.maxValue;
        _fill.color = Color.Lerp(_startColor, Color.red, normilizedFloat);
        _slider.value = _spider.Hunger;
    }
}
