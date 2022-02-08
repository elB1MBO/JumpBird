using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    private int score;

    void Start()
    {
        if(instance==null) instance=this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(){
        score += 1;
        scoreText.text = score.ToString();
    }
}
