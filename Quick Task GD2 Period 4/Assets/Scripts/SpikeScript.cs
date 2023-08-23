using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Rigidbody2D rb2d = col.GetComponent<Rigidbody2D>();   

        if (col.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
        }
    }
}
