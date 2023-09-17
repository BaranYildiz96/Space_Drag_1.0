using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class displayScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       // print("Score: " + $"{ScoreCounter.score1:0.00}");
        ScoreText.text=" " + $"{ScoreCounter.score1:0.00}";
    }

    public Text ScoreText;
}
