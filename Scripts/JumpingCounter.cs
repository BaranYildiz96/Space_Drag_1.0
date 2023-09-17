using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingCounter : MonoBehaviour
{
    private GameObject ScorePoint;

    private double zs1;


    // Start is called before the first frame update
    void Start()
    {
        zs1 =  0.00;

        ScorePoint = GameObject.FindGameObjectWithTag("ScoreCounter");
        
        ScorePoint.GetComponent<Transform>().position = new Vector3(0, 0, (float) zs1);
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

    }

    
}
