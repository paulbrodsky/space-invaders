using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alienmovement : MonoBehaviour
{
    public Transform alien;

    public float waitTime = 1f;

    public Vector3 location;

    public Transform movePoint;

    public bool move;

    public bool goingRight = true;


    void Update()
    {
        waitTime++;

        if (goingRight)
        {
            if (waitTime == 50f)
            {
                transform.Translate(Vector3.right);

                waitTime = 1f;

                if (alien.position.x >= 10f)
                {
                    goingRight = false;

                    transform.Translate(Vector3.down);
                }
            }
        }
        else
        {
            if (waitTime == 50f)
            {
                transform.Translate(Vector3.left);

                waitTime = 1f;

                if (alien.position.x <= -10f)
                {
                    goingRight = true;

                    transform.Translate(Vector3.down);
                }


            }
        }

    }
}
