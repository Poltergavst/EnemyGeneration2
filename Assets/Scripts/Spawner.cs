using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private WaitForSeconds _spawnRate;

    private void Awake()
    {
        _spawnRate = new WaitForSeconds(2f);
    }

    private void Start()
    {
        StartCoroutine(SpawnAfterDelay());
    }

    private IEnumerator SpawnAfterDelay()
    {
        while (true)
        {
            yield return _spawnRate;

            _spawnPoints[UnityEngine.Random.Range(0, _spawnPoints.Length)].SpawnEnemy();
        }
    }
}
