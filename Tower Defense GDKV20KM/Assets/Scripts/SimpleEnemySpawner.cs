using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemySpawner : MonoBehaviour
{
    public EnemyController enemyToSpawn;

    public Transform spawnPoint;

    public float timeBetweenSpawn;
    private float spawnCounter;

    private int amountToSpawn = 15;

    // Start is called before the first frame update
    void Start()
    {
        spawnCounter = timeBetweenSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        if (amountToSpawn > 0)
        {
            spawnCounter -= Time.deltaTime;

            if (spawnCounter <= 0)
            {
                spawnCounter = timeBetweenSpawn;

                Instantiate(enemyToSpawn, spawnPoint.position, spawnPoint.rotation);

                amountToSpawn--;
            }
        }
    }
}
