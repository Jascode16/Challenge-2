using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    //2 second interval between Spawns
    private float spawnCooldown = 1;
    //Tracks the last time a dog was spawned
    private float lastSpawnTime = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& Time.time > lastSpawnTime + spawnCooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //update the last spawn time
            lastSpawnTime = Time.time;
        }
    }
}
