using System;
using UnityEngine;

public class Transition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Camera.main.transform.Translate(0,10,0);
        }
    }
}
