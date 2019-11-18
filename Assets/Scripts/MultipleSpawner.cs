using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleSpawner : MonoBehaviour
{
    // The items that will be cloned and placed in-game
    public GameObject[] prefabs;

    // Minimum time that should pass before spawning again
    public float minSpawnTime = 1f;

    // Maximum time that should pass before spawning again
    public float maxSpawnTime = 5f;

    void Start()
    {
        // At the start of the game, spawn immediately
        Spawn();
    }

    // This function will spawn an element and, after a random time,
    // will call itself again, in an infinite loop
    private void Spawn()
    {
        // Generates the clone
        int index = Random.Range(0, prefabs.Length);
        GameObject prefab = prefabs[index];
        Instantiate(prefab, transform.position, transform.rotation);

        // Randomize the next spawn time
        var spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

        // Calls itself to spawn another gameObject
        Invoke("Spawn", spawnTime);
    }
}
