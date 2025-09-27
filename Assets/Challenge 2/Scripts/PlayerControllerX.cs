using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogSpawnInterval = 1f;
    private float lastSpawnTime = 0;
    private bool canSpawnDog = true;

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime > dogSpawnInterval)
        {
            canSpawnDog = true;
        }
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawnDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastSpawnTime = Time.time;
            canSpawnDog = false;
        }
    }
}
