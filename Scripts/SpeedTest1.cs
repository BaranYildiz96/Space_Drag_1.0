using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class SpeedTest1 : MonoBehaviour
{
    private double speed1 = 1.0 ;

    public GameObject score2;
    
     
    
    

    void Update()
    {
        if (speed1 <= 200)
        {
            speed1 += Time.deltaTime*0.8;
        }

        transform.Translate(new Vector3(0, (float) (-30 - (speed1)), 0) * Time.deltaTime);
        

        Debug.Log(" Speed is : " + speed1);
    }

}