using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static double score1 = 1.00;
    
    // Start is called before the first frame update
    void Start()
    {
        score1 = 0.0;
       print("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
       
        score1 += Time.deltaTime ;
     //   print("Score: " + $"{score1:0.00}");
        ScoreText.text=" " + $"{score1:0.00}";
    }

    public Text ScoreText;

}

