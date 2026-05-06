using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

public class spawner : MonoBehaviour
{
    public GameObject Item;//生成項目
    public float SpawnTime;
    private float cSpawnTime;
    public bool Timer;

    void Start()
    {
        cSpawnTime = SpawnTime;
    }

    void Update()
    {
        if(Timer)
        {
            UpdateTimer();
        }
    }

    private void UpdateTimer()
    {
        if(cSpawnTime > 0)
        {
            cSpawnTime -= Time.deltaTime;
        }
        else
        {
            Spawn();
            cSpawnTime = SpawnTime;
        }
    }
    
    public void Spawn()
    {
        Instantiate(Item, transform.position, transform.rotation);
    }
}