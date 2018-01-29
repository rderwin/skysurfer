using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndWarp : MonoBehaviour {
    public float speedX;
    public float xRepeatOffset;
    public float yBoundaryTop;
    public float yBoundaryBottom;
    public float resetPoint;

    float startPos;
    float startingMovement;
    float movement;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        movement = speedX;
        startingMovement = movement;
        rb = GetComponent<Rigidbody2D>();
        if (resetPoint == 0) {
            startPos = rb.position.x;
        } else {
            startPos = resetPoint;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // player movement
        MovePlayer(movement);
    }

    void MovePlayer(float movementX)
    {
        if (rb.position.x < xRepeatOffset)
        {
            float y = Random.value * (yBoundaryTop - yBoundaryBottom) + yBoundaryBottom;
            rb.position = new Vector2(startPos, y);
        }
        rb.velocity = new Vector3(movementX, 0, 0);
    }

    public void increaseMovement() {
        movement -= (Time.deltaTime / 20f);
    }

    public void stop() {
        movement = 0;
    }

    public void reset() {
        rb.position = new Vector2(startPos, rb.position.y); 
        movement = startingMovement;
    }

}
