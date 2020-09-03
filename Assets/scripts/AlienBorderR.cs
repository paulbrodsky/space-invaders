using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBorderR : MonoBehaviour
{
    public GameObject _AlienController;
    private AlienController script;

    public Transform alien;

    public void moveAtEdge()
    {
        alien.transform.Translate(0f, -0.2f, 0f);
    }


    void Start()
    {
        script = _AlienController.GetComponent<AlienController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "alien")
        {
            script.goingRight = false;

            script.goingLeft = true;

            Invoke("moveAtEdge", 0f);
        }
    }
}
