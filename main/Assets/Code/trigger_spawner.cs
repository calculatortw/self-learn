using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class trigger_spawner : MonoBehaviour
{
    public spawner spawner;

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player"))
        {
            spawner.Spawn();
        }

    }
}