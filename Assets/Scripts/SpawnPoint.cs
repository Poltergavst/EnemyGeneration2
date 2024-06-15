using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;

    private GameObject _enemiesContainer;

    private void Start()
    {
        _enemiesContainer = new GameObject("Enemies" + name);
    }

    public void SpawnEnemy()
    {
        Instantiate(_enemyPrefab, transform.position, Quaternion.identity, _enemiesContainer.transform).Initialize(_target);
    }
}
