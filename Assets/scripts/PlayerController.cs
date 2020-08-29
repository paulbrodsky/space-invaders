using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;

    public float move;

    float speed = 0.2f;

    public Transform position;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(bullet, position.position, position.rotation);
        }

        if (position.position.x >= 20f)
        {
            transform.Translate(Vector3.left);
        }

        if (position.position.x <= -20f)
        {
            transform.Translate(Vector3.right);
        }

        move = Input.GetAxis("Horizontal");

        transform.Translate((move * speed), 0, 0);
    }
}
