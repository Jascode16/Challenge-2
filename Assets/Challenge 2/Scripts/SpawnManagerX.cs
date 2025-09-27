using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
    // Generate random ball index and random spawn position
    Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

    // Instantiate ball at random spawn location
    int ballIndex = Random.Range(0, ballPrefabs.Length);
    Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

    // Schedule next spawn at a random interval between 3 and 5 seconds
    float randomInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
    // Debug.Log("Next ball in: " + randomInterval + " seconds");
    Invoke("SpawnRandomBall", randomInterval);
    }

}
