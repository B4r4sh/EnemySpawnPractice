using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private float _spawnTime;
    [SerializeField] private Transform _firstEnemySpawner;
    [SerializeField] private Transform _seocndEnemySpawner;
    [SerializeField] private Transform _thirdEnemySpawner;
    [SerializeField] private Transform _fourthEnemySpawner;

    private float _nextSpawnTime;
    private int _spawnerCounter;

    void Start()
    {
        _nextSpawnTime = _spawnTime;
        _spawnerCounter = 1;
    }

    void Update()
    {
        if (GameObject.Find("Player") != null)
        {
            if (Time.time > _nextSpawnTime)
            {
                if (_spawnerCounter == 1)
                {
                    SpawnEnemy(_firstEnemySpawner.position);
                }
                else if (_spawnerCounter == 2)
                {
                    SpawnEnemy(_seocndEnemySpawner.position);
                }
                else if (_spawnerCounter == 3)
                {
                    SpawnEnemy(_thirdEnemySpawner.position);
                }
                else if (_spawnerCounter == 4)
                {
                    SpawnEnemy(_fourthEnemySpawner.position);
                    _spawnerCounter = 0;
                }

                _spawnerCounter++;
                _nextSpawnTime += _spawnTime;
            }
        }
    }

    void SpawnEnemy(Vector3 position)
    {
        GameObject enemy = Instantiate(_enemyPrefab, position, Quaternion.identity);
    }
}
