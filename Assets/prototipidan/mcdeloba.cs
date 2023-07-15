using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mcdeloba : MonoBehaviour
{
    public Rigidbody rb;
    public float win = 1f;
    public float marjvniv = 1f;
    public float marcxniv = 1f;
    public float ukan = 1f;
    public float rame = 20f;

    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(0, win, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, -win, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(-marcxniv, 0, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(marjvniv, 0, 0);
        }

    }
    void FixedUpdate()
    {
       

    }

}
