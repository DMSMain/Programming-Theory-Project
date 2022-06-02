using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ENCAPSULATION
    [Header("Obstacle")]
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private Vector2 obstacleSpawnPos;
    [SerializeField] private float obstacleSpawnRange = 2.5f;
    [SerializeField] private float obstacleStartDelay = 2;
    [SerializeField] private float obstacleRepeatRate = 5;

    [Header("Enemy 1")]

    [SerializeField] private GameObject enemy1Prefab;
    [SerializeField] private Vector2 enemy1SpawnPos;
    [SerializeField] private float enemy1StartDelay = 2;
    [SerializeField] private float enemy1RepeatRate = 5;
    [SerializeField] private float enemy1SpawnRange = 4.5f;

    [Header("Enemy 2")]

    [SerializeField] private GameObject enemy2Prefab;
    [SerializeField] private Vector2 enemy2SpawnPos;
    [SerializeField] private float enemy2StartDelay = 2;
    [SerializeField] private float enemy2RepeatRate = 5;
    [SerializeField] private float enemy2SpawnRangeMin = 0f;
    [SerializeField] private float enemy2SpawnRangeMax = 8.5f;

    // ABSTRACTION
    void Start()
    {
        InvokeRepeating("SpawnObstacle", obstacleStartDelay, obstacleRepeatRate);
        InvokeRepeating("SpawnEnemy1", enemy1StartDelay, enemy1RepeatRate);
        InvokeRepeating("SpawnEnemy2", enemy2StartDelay, enemy2RepeatRate);
    }

    void SpawnObstacle()
    {
        obstacleSpawnPos = new Vector2 (10, Random.Range(-obstacleSpawnRange, obstacleSpawnRange));
        Instantiate(obstaclePrefab, obstacleSpawnPos, obstaclePrefab.transform.rotation);
    }

    void SpawnEnemy1()
    {
        enemy1SpawnPos = new Vector2 (10, Random.Range(-enemy1SpawnRange, enemy1SpawnRange));
        Instantiate(enemy1Prefab, enemy1SpawnPos, enemy1Prefab.transform.rotation);
    }

    void SpawnEnemy2()
    {
        enemy2SpawnPos = new Vector2 (Random.Range(enemy2SpawnRangeMin, enemy2SpawnRangeMax), -5.5f);
        Instantiate(enemy2Prefab, enemy2SpawnPos, enemy2Prefab.transform.rotation);
    }
}
