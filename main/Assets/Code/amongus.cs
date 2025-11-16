using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amongus : MonoBehaviour
{
    public float speed = 0.01f;
    Rigidbody2D rigid2D;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigid2D =this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //move
        if (Input.GetKey("d"))
        {
            this.gameObject.transform.position += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            this.gameObject.transform.position += new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rigid2D.AddForce(new Vector2(0, 0.1f), ForceMode2D.Impulse);
        }
    }
}
