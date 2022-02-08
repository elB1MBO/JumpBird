using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic bgMusic;

    void Awake(){
        if(bgMusic==null){
            bgMusic=this;
            DontDestroyOnLoad(bgMusic);
        }else{
            Destroy(this.gameObject);
        }
    }
}
