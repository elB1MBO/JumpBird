using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{

    public GameObject obstaculo;
    public GameObject despawn; //Punto en el que se destruiran los obstaculos

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destruir();
    }

    void Destruir(){
        if(obstaculo.transform.position.x <= despawn.transform.position.x)
            Destroy(this.gameObject);
    }
}
