/**
Clase para el movimiento del escenario, tanto del suelo, techo, fondo y las tuberias.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovEscenario : MonoBehaviour
{
    public GameObject suelo, suelo1, suelo2, techo, techo1, techo2, fondo, fondo1, fondo2;

    public float velocidadSuelo;
    public float factorFondo;

    public GameObject start, end;

    //public GameObject tuberiaPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ManageMovement();   
        ManageParallax();
        ManageSpawnCicle();
    }

    void ManageMovement(){
        suelo.transform.position = new Vector2(suelo.transform.position.x - velocidadSuelo*Time.deltaTime, suelo.transform.position.y);
        suelo1.transform.position = new Vector2(suelo1.transform.position.x - velocidadSuelo*Time.deltaTime, suelo1.transform.position.y);
        suelo2.transform.position = new Vector2(suelo2.transform.position.x - velocidadSuelo*Time.deltaTime, suelo2.transform.position.y);
        techo.transform.position = new Vector2(techo.transform.position.x - velocidadSuelo*Time.deltaTime, techo.transform.position.y);
        techo1.transform.position = new Vector2(techo1.transform.position.x - velocidadSuelo*Time.deltaTime, techo1.transform.position.y);
        techo2.transform.position = new Vector2(techo2.transform.position.x - velocidadSuelo*Time.deltaTime, techo2.transform.position.y);
        /* fondo.transform.position = new Vector2(fondo.transform.position.x - velocidadFondo*Time.deltaTime, fondo.transform.position.y);
        fondo1.transform.position = new Vector2(fondo1.transform.position.x - velocidadFondo*Time.deltaTime, fondo1.transform.position.y); */

        //tuberiaPrefab.transform.position = new Vector2(tuberiaPrefab.transform.position.x - velocidadSuelo*Time.deltaTime, tuberiaPrefab.transform.position.y);
    }

    void ManageParallax(){
        fondo.transform.position = new Vector2(fondo.transform.position.x - velocidadSuelo*factorFondo*Time.deltaTime, fondo.transform.position.y);
        fondo1.transform.position = new Vector2(fondo1.transform.position.x - velocidadSuelo*factorFondo*Time.deltaTime, fondo1.transform.position.y);
        fondo2.transform.position = new Vector2(fondo2.transform.position.x - velocidadSuelo*factorFondo*Time.deltaTime, fondo2.transform.position.y);
    }

    void ManageSpawnCicle(){
        if(suelo.transform.position.x <= end.transform.position.x){
            suelo.transform.position = new Vector2(start.transform.position.x, suelo.transform.position.y);
            techo.transform.position = new Vector2(start.transform.position.x, techo.transform.position.y);
        }
        if(suelo1.transform.position.x <= end.transform.position.x){
            suelo1.transform.position = new Vector2(start.transform.position.x, suelo1.transform.position.y);
            techo1.transform.position = new Vector2(start.transform.position.x, techo1.transform.position.y);
        }
        if(suelo2.transform.position.x <= end.transform.position.x){
            suelo2.transform.position = new Vector2(start.transform.position.x, suelo2.transform.position.y);
            techo2.transform.position = new Vector2(start.transform.position.x, techo2.transform.position.y);
        }
        if(fondo.transform.position.x <= end.transform.position.x){
            fondo.transform.position = new Vector2(start.transform.position.x, fondo.transform.position.y);
        }
        if(fondo1.transform.position.x <= end.transform.position.x){
            fondo1.transform.position = new Vector2(start.transform.position.x, fondo1.transform.position.y);
        }
        if(fondo2.transform.position.x <= end.transform.position.x){
            fondo2.transform.position = new Vector2(start.transform.position.x, fondo2.transform.position.y);
        }
    }
}
