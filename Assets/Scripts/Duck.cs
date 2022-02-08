using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    public GameObject duck;
    [HideInInspector] public GameObject obstacle;

    //public Animator animacion; //para la animacion de morirse

    // Start is called before the first frame update
    void Start()
    {
        obstacle = GameObject.FindGameObjectWithTag("Obstacle");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Obstacle"){
            //animacion.SetTrigger("death");
            Destroy(this.gameObject);
        }
    }
}
