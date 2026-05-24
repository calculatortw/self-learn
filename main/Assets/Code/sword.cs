using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sword : MonoBehaviour
{
    private GameObject object0;
    public Transform playertransform;
    private float atk = 0.5f;
    private float nextatk = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        object0 = GameObject.Find("sword_0");
    }

    // Update is called once per frame
    void Update()
    {
        object0.transform.position = new Vector3(playertransform.position.x, playertransform.position.y, object0.transform.position.z);
        if (Input.GetKey(KeyCode.Mouse0) && Time.time>nextatk)
        {
            nextatk = Time.time + atk;
            transform.Rotate(0, 0, -90f);  
        }
    }
}

