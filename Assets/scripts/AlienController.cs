using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    private Transform enemyHolder;
    public Transform alien;
    public float waitTime = 0f;
    public Vector3 location;
    public bool move;
    public bool goingRight = true;
    public bool goingLeft = false;
    public bool rightEdge = false;
    public bool leftEdge = false;


    void Update()
    {
        waitTime++;



        if (goingRight)
        {
            if (waitTime == 50f)
            {
                transform.Translate(Vector3.right);

                waitTime = 0f;
            }


        }
        if (goingLeft)
        {
            if (waitTime == 50f)
            {
                transform.Translate(Vector3.left);

                waitTime = 0f;
            }
        }
    }
}
