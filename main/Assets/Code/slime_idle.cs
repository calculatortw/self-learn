using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class slime_idle : MonoBehaviour
{
    public Transform[] PatrolPoints;
    public float speed;
    public int PPDS;
    void Update()
    {
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
