using UnityEngine;
using UnityEngine.Events;

public class SpiderWeaver : MonoBehaviour
{
    public UnityAction Weavering;
    public UnityAction WeaveringFailed;

    [SerializeField] private WeaveSliderControl _leftSlider;
    [SerializeField] private WeaveSliderControl _rightSlider;

    private float _web;

    public float Web => _web;

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<ButterFly>(out ButterFly butterFly))
        {
            _web = 0;
            WeaveringFailed?.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.TryGetComponent<ButterFly>(out ButterFly butterFly))
        {
            _web += _leftSlider.Delta + _rightSlider.Delta;
            Weavering?.Invoke();
            butterFly.BecomeCocoon(_web);
        }
    }
}
