using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTuberias : MonoBehaviour
{
    public GameObject tuberiaPrefab;
    public GameObject spawnPoint;
    [SerializeField] private float maxY;
    [SerializeField] private float minY;
    [SerializeField] private float timeBetweenSpawn = 5.0f;
    private float spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=timeBetweenSpawn){
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn(){
        float randomY = Random.Range(minY, maxY);

        GameObject a = Instantiate(tuberiaPrefab) as GameObject;
        a.transform.position = new Vector2(spawnPoint.transform.position.x, randomY);
    }
}
