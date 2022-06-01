using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Obstacle")]
    public GameObject obstaclePrefab;
    public Vector2 obstacleSpawnPos;
    public float obstacleSpawnRange = 2.5f;
    private float obstacleStartDelay = 2;
    private float obstacleRepeatRate = 5;

    [Header("Enemy 1")]

    public GameObject enemy1Prefab;
    public Vector2 enemy1SpawnPos;
    private float enemy1StartDelay = 2;
    private float enemy1RepeatRate = 5;
    public float enemy1SpawnRange = 4.5f;

    [Header("Enemy 2")]

    public GameObject enemy2Prefab;
    public Vector2 enemy2SpawnPos;
    private float enemy2StartDelay = 2;
    private float enemy2RepeatRate = 5;
    public float enemy2SpawnRangeMin = 0f;
    public float enemy2SpawnRangeMax = 8.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", obstacleStartDelay, obstacleRepeatRate);
        InvokeRepeating("SpawnEnemy1", enemy1StartDelay, enemy1RepeatRate);
        InvokeRepeating("SpawnEnemy2", enemy2StartDelay, enemy2RepeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
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
