using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class CocoonPercentageDisplay : MonoBehaviour
{
    [SerializeField] private SpiderWeaver _spider;

    private TextMeshProUGUI _text;

    private void Awake()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        _spider.Weavering += Show;
        _spider.WeaveringFailed += Erase;
    }

    private void OnDisable()
    {
        _spider.Weavering -= Show;
        _spider.WeaveringFailed -= Erase;
    }

    private void Show()
    {
        _text.text = ((int)_spider.Web).ToString() + "%";
    }

    private void Erase()
    {
        _text.text = "";
    }
}
