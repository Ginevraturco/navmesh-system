using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 5f;

    void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);

        var spawnTime = Random.Range(minSpawnTime, maxSpawnTime);

        Invoke("Spawn", spawnTime);
    }

}
