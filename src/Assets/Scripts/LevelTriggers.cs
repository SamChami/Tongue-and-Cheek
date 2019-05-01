using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTriggers : MonoBehaviour
{
    public Transform SpawnPoint;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Finish"))
        {
            levelComplete();
        } else if (col.CompareTag("Failed"))
        {
            levelFailed();
        }
    }


    void levelComplete()
    {
        Debug.Log("Complete");

    }

    void levelFailed()
    {
        transform.position = SpawnPoint.position;
    }
}

