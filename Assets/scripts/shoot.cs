using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject bullet;

    public float speed = 0.1f;

    void Update()
    {
        transform.Translate(0, speed, 0);
    }
}
