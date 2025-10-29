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
        status = Status.walk;
        if (this.transform.GetComponent<SpriteRenderer>().flipX)
        {
            face = Face.Left;
        }
        else
        {
            face = Face.Right;
        }
        myTransform = this.transform;
    }
    void Update()
    {
        float deltaTime = Time.deltaTime;
        switch (status)
        {
            case Status.idle:
                break;
            case Status.walk:
            
                switch (face)
                {
                    case Face.Right:
                        myTransform.position += new Vector3(speed*deltaTime,0,0);
                        break;
                    case Face.Left:
                        myTransform.position -= new Vector3(speed*deltaTime,0,0);
                        break;
                }
                break;
        }
    }

}
