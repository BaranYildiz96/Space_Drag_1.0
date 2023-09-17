using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{

    /* void OnCollisionEnter(Collision other)
   // {
        //if (other.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    } */

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            SoundManager.PlaySound("crash");
            StartCoroutine(ExecuteAfterTime(0));
            SceneManager.LoadScene("GameOver");


        }
    }


    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
