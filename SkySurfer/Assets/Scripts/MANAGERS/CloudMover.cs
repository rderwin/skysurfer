using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour
{
    float startPos;
    float movement;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = - 0.3f - (.3f) * Random.value; 
    }

    // Update is called once per frame
    void Update()
    {
        // player movement
        MovePlayer(movement);
    }

    void MovePlayer(float movementX)
    {
        if (rb.position.x < -12)
        {
            movement = -0.5f - (0.5f) * Random.value;
            rb.position = new Vector2(12 + (8f * Random.value), -1.5f + (6.5f * Random.value));
        }
        rb.velocity = new Vector3(movementX, 0, 0);
    }

    public void stop()
    {
        movement = 0;
    }




}