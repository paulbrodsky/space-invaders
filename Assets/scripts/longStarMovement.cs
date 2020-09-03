using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longStarMovement : MonoBehaviour
{
    public float speed;

    public Transform star;

    // Update is called once per frame
    void Update()
    {
        speed = -2f;

        transform.Translate(0, speed, 0);

        if (star.position.y <= -20f)
        {
            Destroy(star.gameObject);
        }
    }
}
