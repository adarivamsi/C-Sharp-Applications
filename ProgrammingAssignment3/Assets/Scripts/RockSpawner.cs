using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Rock Spawner helps the rocks to spawn
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // Needed for Spawning
    [SerializeField]
    GameObject prefabRock;

    // Spawn Control
    Timer spawnTimer;

    // Count Rocks
    int countRock = 0;

    /// <summary>
    /// Use this of intialization
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        // Create and Start Timer
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();
    }

    /// <summary>
    /// Update is called once for frame
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        countRock = GameObject.FindGameObjectsWithTag("CountRock").Length;
        if (spawnTimer.Finished && countRock < 3)
        {
            Instantiate(prefabRock);
            spawnTimer.Run();
        }
    }
}