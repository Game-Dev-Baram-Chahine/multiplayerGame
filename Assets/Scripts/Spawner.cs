using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;   // The prefab to spawn
    public float spawnInterval = 10f; // The time interval between spawns

    private float timer; // Timer for tracking the spawn interval

    private void Start()
    {
        timer = spawnInterval;
    }

    private void Update()
    {
        // Reduce the timer
        timer -= Time.deltaTime;

        // Check if it's time to spawn a new prefab
        if (timer <= 0f)
        {
            SpawnPrefab();
            timer = spawnInterval; // Reset the timer
        }
    }

    private void SpawnPrefab()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}

