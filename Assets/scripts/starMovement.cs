using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starMovement : MonoBehaviour
{
    public float speed;

    public Transform star;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);

        if (star.position.y <= -11f)
        {
            Destroy(star.gameObject);
        }
    }
}
