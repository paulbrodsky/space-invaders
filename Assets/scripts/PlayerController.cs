using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;

    public cameraShake Shaker;

    public float move;

    public float duration = 1f;

    float speed = 0.2f;

    public float coolDown = 0f;

    public Transform position;

    void Update()
    {
        coolDown++;

        if (Input.GetKeyDown("space") && coolDown >= 50f)
        {
            Instantiate(bullet, position.position, position.rotation);

            coolDown = 0f;

            Shaker.Shake(0.08f);
        }

        if (position.position.x >= 20f)
        {
            position.position = new Vector2(20, -9);
        }

        if (position.position.x <= -20f)
        {
            position.position = new Vector2(-20, -9);
        }

        move = Input.GetAxis("Horizontal");

        transform.Translate((move * speed), 0, 0);
    }
}
