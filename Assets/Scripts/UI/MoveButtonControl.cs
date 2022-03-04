using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveButtonControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public UnityAction<string> PressedEvent;
    public UnityAction<string> UnpressedEvent;

    private Image _button;
    private Color _defaultColor;

    private void Awake()
    {
        _button = GetComponent<Image>();
        _defaultColor = _button.color;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _button.color = Color.red;
        PressedEvent?.Invoke(_button.name);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _button.color = _defaultColor;
        UnpressedEvent?.Invoke(_button.name);
    }
}
