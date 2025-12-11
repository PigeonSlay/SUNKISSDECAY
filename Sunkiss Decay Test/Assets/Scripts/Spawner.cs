using System;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject minion;

    public float timeToSpawn;
    private float spawnCounter; 
    

    private void Start()
    {
        spawnCounter = timeToSpawn;
    }

    void Update()
    {
        spawnCounter -= Time.deltaTime;

        if (spawnCounter <= 0)
        {
            spawnCounter = timeToSpawn;
            Instantiate(minion, transform.position, transform.rotation);
        }
    }
    
}
