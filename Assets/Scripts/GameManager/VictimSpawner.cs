using System.Collections;
using UnityEngine;

public class VictimSpawner : MonoBehaviour
{
    [SerializeField] GameObject _victimPrefab;
    [SerializeField] private float _minSpawnDelay;
    [SerializeField] private float _maxSpawnDelay;
    [SerializeField] private Transform _webCenter;
    [SerializeField] private float _spread;
    [SerializeField] private float _zPosition;

    private float _xMinPosition;
    private float _xMaxPosition;
    private float _yMinPosition;
    private float _yMaxPosition;
    private Coroutine _spawnCoroutine;

    private void Start()
    {
        _xMinPosition = _webCenter.position.x - _spread;
        _xMaxPosition = _webCenter.position.x + _spread;
        _yMinPosition = _webCenter.position.y - _spread;
        _yMaxPosition = _webCenter.position.y + _spread;

        _spawnCoroutine = StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopCoroutine(_spawnCoroutine);
    }

    private IEnumerator Spawn()
    {
        bool isGameOver = false;

        while (!isGameOver)
        {
            Instantiate(_victimPrefab, new Vector3(Random.Range(_xMinPosition, _xMaxPosition), Random.Range(_yMinPosition, _yMaxPosition), _zPosition), _victimPrefab.transform.rotation);
            float delay = Random.Range(_minSpawnDelay, _maxSpawnDelay);
            yield return new WaitForSeconds(delay);
        }
    }
}
