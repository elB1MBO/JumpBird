using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    public GameObject obstacle;
    public GameObject scorePoint;
    public float maxX, minX, maxY, minY;
    public float  timeBetweenSpawn;
    private float spawnTime; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime){
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }   
    }

    void Spawn(){
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        Instantiate(scorePoint, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
