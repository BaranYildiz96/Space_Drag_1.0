using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHole : MonoBehaviour
{
    
    private Vector3 point;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float turndegreesinsecond = -180;
        
        if (!Mathf.Approximately(horizontalInput, 0))
        {
            transform.Rotate(0,0,horizontalInput*turndegreesinsecond*Time.deltaTime);
        }
    }     
}

