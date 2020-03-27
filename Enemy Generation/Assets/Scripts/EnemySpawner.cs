using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints = new Transform[4];
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        for (int i = 0; i < _spawnPoints.Length; i++)
        {
            int RandomSpawn = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[RandomSpawn]);
            yield return new WaitForSeconds(2f);
        }
    }
}
