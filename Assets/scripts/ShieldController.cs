using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    public float health = 5f;

    public GameObject shield;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            health -= 1f;
        }
    }

    void Update()
    {
        if (health == 0f)
        {
            Destroy(shield);
        }
    }
}
