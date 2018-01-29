using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {

    bool gravity;
    bool falling;
    Rigidbody2D rb;

    void Start()
    {
        gravity = true;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (gravity)
            rb.gravityScale = 0.02f;
        else
            rb.gravityScale = -0.02f;

    }
    void Awake()
    {
        InvokeRepeating("Switch", 1, 2);
    }

    void Switch()
    {
        gravity = !gravity;
        falling = !falling;
        //rb.velocity = new Vector3(0, 0, 0);
    }
}
