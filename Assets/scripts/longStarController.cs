using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longStarController : MonoBehaviour
{
    public float starLocation;

    public Transform star;
    public Transform controller;

    void Start()
    {
        InvokeRepeating("createStar", 0f, 0.1f);
    }

    void createStar()
    {
        Instantiate(star, controller.position, controller.rotation);

    }

    void Update()
    {
        starLocation = Random.Range(-21f, 21f);

        controller.position = new Vector2(starLocation, 25f);
    }
}
