using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePoint : MonoBehaviour
{
    public GameObject scorePoint;
    public float speed;
    private bool usado;

    void Start()
    {
        speed=10.0f;
        usado=false;
    }

    // Update is called once per frame
    void Update()
    {
        scorePoint.transform.position = new Vector2(scorePoint.transform.position.x - speed*Time.deltaTime, scorePoint.transform.position.y);
    }

    private void OnTriggerExit2D(Collider2D collision){
        if((collision.tag == "Player") && !usado){
            ScoreManager.instance.ChangeScore();    //Si choca con el pato, llama a la funcion del scoreManager para que cambie la puntuacion
            usado=true;
        }
        if(collision.tag == "Despawn"){
            Destroy(this.gameObject);
        }
    }
}
