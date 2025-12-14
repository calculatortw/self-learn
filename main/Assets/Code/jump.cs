using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rigid2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid2D = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            //rigid2D.AddForce(new Vector2(0, 0.01f), ForceMode2D.Impulse);
            this.gameObject.transform.position += new Vector3(0, 0.05f, 0);
        }
    }
}
