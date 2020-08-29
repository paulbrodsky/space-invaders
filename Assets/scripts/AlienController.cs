using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    private Transform enemyHolder;
    public Transform alien;

    public GameObject alienObject;

    public float waitTime = 1f;

    public Vector3 location;

    public bool move;

    public bool goingRight = true;


    void Update()
    {
        waitTime++;

        // if (enemyHolder.childCount == 0)
        // {
        //     SceneManager.LoadScene("SampleScene");
        // }

        if (goingRight)
        {
            if (waitTime == 25f)
            {
                transform.Translate(Vector3.right);

                waitTime = 1f;

                if (alien.position.x >= 7f)
                {
                    goingRight = false;

                    transform.Translate(Vector3.down);
                }
            }
        }
        else
        {
            if (waitTime == 25f)
            {
                transform.Translate(Vector3.left);

                waitTime = 1f;

                if (alien.position.x <= -7f)
                {
                    goingRight = true;

                    transform.Translate(Vector3.down);
                }


            }
        }

    }
}
