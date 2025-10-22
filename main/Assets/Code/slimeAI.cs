using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class slimeAI : MonoBehaviour{
    public enum Status{idle, walk};
    public Status status;
    public enum Face{right, left};
    public Face face;
    public float speed;

    void Start()
    {
        status = Status.idle;
        if (this.transform.GetComponent<SpriteRenderer>().flipX)
        {
            face = Face.left;
        }
        else
        {
            face = Face.right;
        }

    }
    void Update()
    {
        switch (status)
        {
            case Status.idle:
                break;
            case Status.walk:
                switch (face)
                {
                    case Face.right:

                        break;
                    case Face.left:

                        break;
                }
                break;
        }
    }

}
