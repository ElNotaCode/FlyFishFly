using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject cloud;
    public GameObject rareCloud;
    public float cloudSpawnTime;
    private float timer = 0;
    public float heightOffset;

    void Start()
    {
        SpawnCloud();
    }

    void Update()
    {

        if (timer < cloudSpawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }

    }
    private void SpawnCloud()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;
        if(Random.Range(1,1000) == 1)
        {
            Instantiate(rareCloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 1), transform.rotation);
        }
        else
        {
            Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 1), transform.rotation);
        }
        
    }
}
