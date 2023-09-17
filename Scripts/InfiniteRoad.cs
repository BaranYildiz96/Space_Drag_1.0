using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    private GameObject BlackHole1, BlackHole2 , BlackHole3;

    private int z1, z2, z3;

    // Start is called before the first frame update
    void Start()
    {
        z1 = 0;
        z2 = 300;
        z3 = 600;

        BlackHole1 = GameObject.FindGameObjectWithTag("BlackHole1");
        BlackHole2 = GameObject.FindGameObjectWithTag("BlackHole2");
        BlackHole3 = GameObject.FindGameObjectWithTag("BlackHole3");

        BlackHole1.GetComponent<Transform>().position = new Vector3(0, 0, z1);
        BlackHole2.GetComponent<Transform>().position = new Vector3(0, 0, z2);
        BlackHole3.GetComponent<Transform>().position = new Vector3(0, 0, z3);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlackHole3" && z3 < z2)
        {
            z3 += 900;
            BlackHole3.GetComponent<Transform>().position = new Vector3(0, 0, z3);
        }
        else if (other.gameObject.tag == "BlackHole2" && z2 < z1)
        {
            z2 += 900;
            BlackHole2.GetComponent<Transform>().position = new Vector3(0, 0, z2);
        }

        else if (other.gameObject.tag == "BlackHole1" && z1 < z2)
        {
            z1 += 900;
            BlackHole1.GetComponent<Transform>().position = new Vector3(0, 0, z1);
        }
    }
}