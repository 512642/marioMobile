using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    [Header("Player Variables")]
    [SerializeField]    float x;
    [SerializeField]    float speed;
    [SerializeField]    float walk;
    [SerializeField]    float run;
    [SerializeField]    float jumpPower;
    [SerializeField]    int extraJump;


    [Header ("Physics")]
    [SerializeField]  Rigidbody2D rb;
    [SerializeField] bool hasJumped;
    [SerializeField] LayerMask GroundLayer;
    [SerializeField] Transform checkForFloor;

    [Header("Scripts")]
    [SerializeField] ButtonsScript jumpButtonScipt;
    [SerializeField] ButtonsScript sprintButtonScipt;
    [SerializeField] Joystick joystick;


    int jumpCount = 0;
    bool isGrounded;
    float jumpCoolDown;

    float currentTime = 0;
    float startingTime = 2f;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        speed = walk;
        rb = gameObject.GetComponent<Rigidbody2D>();
        bool sprintButtonPressed = sprintButtonScipt.sprintPresseed;
        bool jumpButtonPressed = jumpButtonScipt.jumpPressed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Walking();
        SpeedUp();
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
            jumpCount ++;
        }        
    }

    void CheckGrounded()
    {
        if(Physics2D.OverlapCircle(checkForFloor.position, 0.5f, GroundLayer))
        {
            isGrounded = true;
            jumpCount = 0;
            jumpCoolDown = Time.time + 0.2f;
        }
        else if(Time.time < jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
    void SpeedUp()
    {
        if (x > 0.1 || x < 0.1)
        {
            currentTime -= 1 * Time.time;
        }
        if( currentTime < 1)
        {
            speed = run;
        }
        else
        {
            speed = walk;
        }
            
    }
}
