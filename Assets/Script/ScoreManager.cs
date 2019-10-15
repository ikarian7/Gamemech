﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;
    public Text text;
    int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }    
    }

    public void ChangeScore(int value)
    {
        score = score + value;
        Debug.Log(score);
        text.text = "Collected: " + score.ToString() + "/4";
        if (score == 4)
        {
            Time.timeScale = 0f; 
        }
    }
}
