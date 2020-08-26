using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienmovement : MonoBehaviour
{
    public float speed = 1000f;

    public Transform alien;

    public float waitTime = 1f;

    public Vector3 location;

    public Transform movePoint;

    public bool move;


    void Start()
    {


    }
    void Update()
    {
        waitTime++;

        if (waitTime == 100f)
        {
            transform.Translate(Vector3.right);

            waitTime = 1f;
        }
    }
}
