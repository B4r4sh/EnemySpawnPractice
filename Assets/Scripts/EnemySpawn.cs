using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private float _spawnTime;
    [SerializeField] private Transform[] _enemySpawners = new Transform[4];

    private int _spawnerCounter;

    void Start()
    {
        _spawnerCounter = 0;
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (PlayerDetection._isPlayerActiv)
        {
            var enemy = Instantiate(_enemyPrefab, _enemySpawners[_spawnerCounter].position, Quaternion.identity);

            _spawnerCounter++;

            if (_spawnerCounter == _enemySpawners.Length)
            {
                _spawnerCounter = 0;
            }

            yield return new WaitForSeconds(_spawnTime);
        }
    }
}
