using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
public class slime_idle : MonoBehaviour
{
    public Transform[] PatrolPoints;
    public float speed;
    public int PPDS; // 巡邏終點
    public Transform playerTransform;
    public bool Chasing;
    public float cDS; // 追蹤距離
    void Update()
    {
        if (Chasing)
        {
            if (transform.position.x > playerTransform.position.x)
            {
                transform.position += Vector3.left * speed * Time.deltaTime;
            }
            if (transform.position.x < playerTransform.position.x)
            {
                transform.position += Vector3.right * speed * Time.deltaTime;
            }

        }
        else
        {
            if (Vector2.Distance(transform.position, playerTransform.position) < cDS)
            {
                Chasing = true;
            }
            if (PPDS == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[0].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PatrolPoints[0].position) < 0.1f)
            {
                PPDS = 1;
            }
        }

        if (PPDS == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, PatrolPoints[1].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, PatrolPoints[1].position) < 0.1f)
            {
                PPDS = 0;
            }

        }

        }

    }
}
