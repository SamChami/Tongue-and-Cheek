using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTriggers : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Finish"))
        {
            Debug.Log("MyTag");
        } 
        if (col.CompareTag("Failed"))
        {
            Debug.Log("DIED");
        }

    }


    void levelComplete()
    {

    }

    void levelFailed()
    {

    }
}

