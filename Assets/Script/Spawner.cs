using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate;
    public float spawnDistance;

    public GameObject player;

    public float timeSincelastSpawn;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //

    // Update is called once per frame
    void Update()
    {
        timeSincelastSpawn += Time.deltaTime;

        if (timeSincelastSpawn >= spawnRate && player.GetComponent<PlayerHealth>().playerHealth > 0)
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
