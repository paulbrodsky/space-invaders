using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject bullet;

    public Transform bulletPos;

    public Transform alien;

    public float speed = 0.1f;

    void Update()
    {
        transform.Translate(0, speed, 0);

        if (bulletPos.position.y >= 11f)
        {
            Destroy(bulletPos.gameObject);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "alien")
        {
            Destroy(bulletPos.gameObject);
            Destroy(other.gameObject);
        }

        if (other.tag == "shield")
        {
            Destroy(bulletPos.gameObject);
        }
    }

}
