using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMechanics : PlayerMain
{
    [Header("Player Variables")]
    [SerializeField] float x;
    [SerializeField] float speed;
    [SerializeField] float walk;
    [SerializeField] float run;
    [SerializeField] float jumpPower;
    [SerializeField] int extraJump;
    [SerializeField] GameObject RespawnPoint;
    [SerializeField] public int lives = 5;


    [Header("Physics")]
    [SerializeField] Rigidbody2D rb;
    [SerializeField] bool hasJumped;
    [SerializeField] LayerMask GroundLayer;
    [SerializeField] Transform checkForFloor;

    [Header("Scripts")]
    [SerializeField] ButtonsScript jumpButtonScipt;
    [SerializeField] Joystick joystick;
    [SerializeField] Text finalScoreText;

    public GameObject EndGameButtons;
    public GameObject LevelWonButtons;
    int jumpCount = 0;
    bool isGrounded;
    float jumpCoolDown;

    float finalScore;
    float currentTime = 0;
    float startingTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        speed = walk;
        rb = gameObject.GetComponent<Rigidbody2D>();
        bool jumpButtonPressed = jumpButtonScipt.jumpPressed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Walking();
        CheckGrounded();
    }

    public void Walking()
    {
        x = joystick.Horizontal;
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
    }


    public void Jumping()
    {
        if (isGrounded || jumpCount < extraJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpCount++;
        }
    }

    void CheckGrounded()
    {
        if (Physics2D.OverlapCircle(checkForFloor.position, 0.5f, GroundLayer))
        {
            isGrounded = true;
            jumpCount = 0;
            jumpCoolDown = Time.time + 0.2f;
        }
        else if (Time.time < jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    //displayLives = lives.ToString("F0");
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Death" || gameObject.transform.position.y < -7)
        {            
            if(lives > 1)
            {
                gameObject.transform.position = RespawnPoint.transform.position;
                lives--;
            }
            else
            {

                EndGameButtons.SetActive(true);

            }
        }

        if(collision.collider.tag == "Finish")
        {
            LevelWonButtons.SetActive(true);
            finalScore = score;
            finalScoreText.text = ("Final Score: " + finalScore.ToString("F0"));
        }
    }
}

