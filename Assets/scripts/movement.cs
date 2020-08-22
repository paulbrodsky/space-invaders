using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
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

       move = Input.GetAxis("Horizontal");

       transform.Translate((move * speed), 0, 0);
    }
}
