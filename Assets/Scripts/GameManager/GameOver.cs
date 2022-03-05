using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GameOver : MonoBehaviour
{
    [SerializeField] private Spider _spider;
    [SerializeField] private Image _endScreen;
    [SerializeField] private AudioClip _gameOver;

    private float _time;
    private Color _endColor;
    private Color _defaultColor;
    private AudioSource _audioSource;

    public bool IsGameOver { get; private set; }

    private void Awake()
    {
        _endColor = new Color(0, 0, 0, 1);
        _defaultColor = _endScreen.color;
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        _spider.GameOverEvent += EndGame;
    }

    private void OnDisable()
    {
        _spider.GameOverEvent -= EndGame;
    }

    private void EndGame()
    {
        bool isEndEffectShowed = false;

        IsGameOver = true;

        _audioSource.Stop();

        StartCoroutine(ShowEndEffect());
        StartCoroutine(Quit());

        IEnumerator ShowEndEffect()
        {
            float darknessDuration = 0.5f;
            float normilizedFloat = 0;
            float lastValueBeforeOne = 0.98f;

            _audioSource.PlayOneShot(_gameOver);

            while (_endScreen.color != _endColor)
            {
                if (normilizedFloat > lastValueBeforeOne)
                    normilizedFloat = 1;
                else
                    normilizedFloat = _time / darknessDuration;

                _time += Time.deltaTime;

                _endScreen.color = Color.Lerp(_defaultColor, _endColor, normilizedFloat);
                Time.timeScale = Mathf.Lerp(1, 0, normilizedFloat);
                yield return null;
            }

            Time.timeScale = 1;
            yield return new WaitForSeconds(1);
            isEndEffectShowed = true;
        }

        IEnumerator Quit()
        {
            yield return new WaitUntil(() => isEndEffectShowed);
            SceneManager.LoadScene(0);
        }
    }
}
