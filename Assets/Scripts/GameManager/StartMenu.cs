using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private Animator _spiderAnimator;

    private Coroutine _animateSpider;

    private void Awake()
    {
        _animateSpider = StartCoroutine(AnimateSpider());
    }

    private void OnDisable()
    {
        StopCoroutine(_animateSpider);
    }

    public void OnStartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    private IEnumerator AnimateSpider()
    {
        bool isSceneActive = true;
        float delay = 0.25f;

        const string LeftForth = "Left_1_Forth";
        const string LeftBack = "Left_1_Back";
        const string RightForth = "Right_1_Forth";
        const string RightBack = "Right_1_Back";

        while (isSceneActive)
        {
            _spiderAnimator.SetTrigger(LeftForth);
            yield return new WaitForSeconds(delay);
            _spiderAnimator.SetTrigger(LeftBack);
            _spiderAnimator.SetTrigger(RightForth);
            yield return new WaitForSeconds(delay);
            _spiderAnimator.SetTrigger(RightBack);
        }
    }
}
