using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CrappyPlayerManager : MonoBehaviour 
{
	public float speedX;
	public float speedY;
    public float speedRotation;
    public bool easyBoard;

	float movementX;
	float movementY;
    float rotation;

    bool speedMode;
    bool stopped;


	Rigidbody2D rb;

	// Use this for initialization
	void Start () 
    {
        speedMode = false;
        stopped = false;
		rb = GetComponent<Rigidbody2D>();
        if (GlobalControl.Instance.getEasyMode())
        {
            rb.mass = 0.1f;
        }
        if (easyBoard && !GlobalControl.Instance.getEasyMode())
        {
            Destroy(gameObject);
        }
        else if (!easyBoard && GlobalControl.Instance.getEasyMode()) {
            Destroy(gameObject);
        }

	}
	
	// Update is called once per frame
	void Update () 
	{
        // right player movement
        if (Input.GetKey(KeyCode.LeftShift)) {
            speedMode = true;
        } else {
            speedMode = false;
        }

		// player movement
		MovePlayer(movementX, movementY, rotation);

		// left player movement
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			movementX = -speedX;
		}
		if(Input.GetKeyUp(KeyCode.LeftArrow))
		{
			movementX = 0;
		}
		//

		// right player movement
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			movementX = speedX;
		}
		if(Input.GetKeyUp(KeyCode.RightArrow))
		{
			movementX = 0;
		}

		// up player movement
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			movementY = speedY;
		}
		if(Input.GetKeyUp(KeyCode.UpArrow))
		{
			movementY = 0;
		}
		//

		// down player movement
		if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			movementY = -speedY;
		}
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			movementY = 0;
		}


        if (rb.position.y < -5 && movementY < 0)
        {
            movementY = 0;
        }


        if (Input.GetKey(KeyCode.A))
        {
            rotation = speedRotation;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rotation = -speedRotation;
        }
        else 
        {
            rotation = 0;
        }

        float valueX = Input.GetAxis ("Horizontal"); 
        float valueY = Input.GetAxis ("Vertical"); 

        /*
        if (valueX > 0 || valueX < 0 || valueY > 0 || valueY < 0) {
            GlobalControl.Instance.setIsUsingController(true);
        }
        if (GlobalControl.Instance.getIsUsingController()) {
            movementX = valueX * speedX;
            movementY = valueY * speedY;
            rotation = Input.GetAxis("Fire1");
        }
        */

        speedX += (Time.deltaTime / 50f);
        speedY += (Time.deltaTime / 50f);

	}

    void MovePlayer(float x, float y, float rot)
	{
        if (stopped)
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.Rotate(0, 0, 0);
        }
        else {
            if (speedMode)
            {
                x *= 1.3f;
                y *= 1.3f;
                rot *= 1.33f;
            }
            rb.velocity = new Vector3(x, y, 0);
            transform.Rotate(0, 0, rot * Time.deltaTime);
        }
	}

    public void stop() {
        stopped = true;
    }
	

}










