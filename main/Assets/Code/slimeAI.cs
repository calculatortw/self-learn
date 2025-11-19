using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class slimeAI : MonoBehaviour{
    public enum Status{idle, walk};
    public Status status;
    public enum Face{Right, Left};
    public Face face;
    public float speed;
    private Transform myTransform;
    public Transform playerTransform;

    void Start()
    {
        status = Status.idle;

        if (this.transform.GetComponent<SpriteRenderer>().flipX)
        {
            face = Face.Left;
        }
        else
        {
            face = Face.Right;
        }
        myTransform = this.transform;
        playerTransform = GameObject.Find("amongus1_0").transform;
    }
    void Update()
    {
        float deltaTime = Time.deltaTime;
        switch (status)
        {
            case Status.idle:
            if (playerTransform)
                {
                    if (Mathf.Abs(myTransform.position.x - playerTransform.position.x) < 7f)
                    {
                        status = Status.walk;
                    }
                }
                break;
            case Status.walk:
            if (playerTransform)
                {
                    if (myTransform.position.x >= playerTransform.position.x)
                    {
                        face = Face.Left;
                    }
                    else
                    {
                        face = Face.Right;
                    }
                }
                switch (face)
                {
                    case Face.Right:
                        myTransform.position += new Vector3(speed * deltaTime, 0, 0);
                        break;
                    case Face.Left:
                        myTransform.position -= new Vector3(speed * deltaTime, 0, 0);
                        break;
                }
                if (playerTransform)
                {
                    if (Mathf.Abs(myTransform.position.x - playerTransform.position.x) >= 7f)
                    {
                        status = Status.idle;
                    }
                }
                break;
        }
    }

}
