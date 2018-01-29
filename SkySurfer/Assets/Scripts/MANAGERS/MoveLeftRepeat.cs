using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRepeat : MonoBehaviour {
    public float speedX;
    public float xRepeatOffset;

    float startPos;
    float movement;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        movement = speedX;
        rb = GetComponent<Rigidbody2D>();
        startPos = rb.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        // player movement
        MovePlayer(movement);
    }

    void MovePlayer(float movementX)
    {
        if (rb.position.x < xRepeatOffset) {
            rb.position = new Vector2(startPos, rb.position.y);
        }
        rb.velocity = new Vector3(movementX, 0, 0);
    }

    public void stop()
    {
        movement = 0;
    }

    public void reset()
    {
        rb.position = new Vector2(startPos, rb.position.y);
        movement = speedX;
    }




}