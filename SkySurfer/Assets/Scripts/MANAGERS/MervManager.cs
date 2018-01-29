using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MervManager : MonoBehaviour
{
    public UnityEngine.UI.Text scoreText;
    public MoveLeftAndWarp barrierOne;
    public MoveLeftAndWarp barrierOneBottom;
    public MoveLeftAndWarp barrierTwo;
    public MoveLeftAndWarp barrierThree;
    public MoveLeftAndWarp barrierFour;
    public MoveLeftAndWarp barrierFourBottom;
    public MoveLeftRepeat background;
    public GameObject deadPlayerImage;
    public GameObject gameOverImage;
    public Button gameOverButton;
    public CrappyPlayerManager platform;

    public CloudMover cloud1;
    public CloudMover cloud2;
    public CloudMover cloud3;
    public CloudMover cloud4;
    public CloudMover cloud5;
    public CloudMover cloud6;

    public MoveLeftRepeat sea;

    Rigidbody2D rb;
    bool dead;
    float score;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (GlobalControl.Instance.getEasyMode()) {
            rb.mass = 16f;
            rb.gravityScale = 1f;
        }
        dead = false;
        deadPlayerImage.SetActive(false);
        gameOverImage.SetActive(false);
        gameOverButton.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }


        barrierOne.increaseMovement();
        barrierTwo.increaseMovement();
        barrierThree.increaseMovement();
        barrierOneBottom.increaseMovement();
        barrierFour.increaseMovement();
        barrierFourBottom.increaseMovement();

        if (dead) {
            deadPlayerImage.SetActive(true);
            gameOverImage.SetActive(true);
            gameOverButton.gameObject.SetActive(true);

            barrierOne.stop();
            barrierOneBottom.stop();
            barrierTwo.stop();
            barrierThree.stop();
            barrierFour.stop();
            barrierFourBottom.stop();
            background.stop();
            cloud1.stop();
            cloud2.stop();
            cloud3.stop();
            cloud4.stop();
            cloud5.stop();
            cloud6.stop();
            sea.stop();
            platform.stop();
            if (Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        } else {
            score += Time.deltaTime;
            scoreText.text = "SCORE: " + (score.ToString("0"));
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "boundaryBottom" || other.gameObject.name == "boundaryLeft")
        {
            dead = true;
        }
    }
}