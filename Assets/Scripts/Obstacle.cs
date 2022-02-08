using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject obstacle;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        obstacle.transform.position = new Vector2(obstacle.transform.position.x - speed*Time.deltaTime, obstacle.transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Despawn"){
            Destroy(this.gameObject);
        }
    }
}
