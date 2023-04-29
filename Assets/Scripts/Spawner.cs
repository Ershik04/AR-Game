using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float _spawnRadius;
    [SerializeField]
    private Enemy[] _enemies;
    [SerializeField]
    private float _spawnTime;
    [SerializeField]
    private Player _target;

    private void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
    }

    private void Update()
    {
        
    }

    private IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            Enemy enemy = Instantiate(_enemies[Random.Range(0, _enemies.Length)], GetRandomPlace(_spawnRadius), Quaternion.identity);
            Vector3 lookDirection = _target.transform.position - enemy.transform.position;
            enemy.transform.rotation = Quaternion.LookRotation(lookDirection);
            enemy.Dying += OnEnemyDying;
            yield return new WaitForSeconds(_spawnTime);
        }
    }

    private Vector3 GetRandomPlace(float radius)
    {
        return Random.insideUnitSphere * radius;
    }

    private void OnEnemyDying(Enemy enemy)
    {
        enemy.Dying -= OnEnemyDying;
        _target.AddScore();
    }
}
