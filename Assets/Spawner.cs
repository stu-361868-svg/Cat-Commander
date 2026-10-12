using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate;
    public float spawnDistance;

    public float timeSincelastSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        timeSincelastSpawn += Time.deltaTime;

        if (timeSincelastSpawn >= spawnRate)
        {
            SpawnEnemy();
            timeSincelastSpawn = 0f;
        }

        
    }

    void SpawnEnemy()
    {
        Vector2 spawnPosition = Random.insideUnitCircle.normalized * spawnDistance;
        spawnPosition += (Vector2)transform.position;

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
