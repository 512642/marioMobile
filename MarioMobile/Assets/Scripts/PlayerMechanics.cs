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
    [SerializeField]    float jump;
    [SerializeField]    float fallMultiplier;
    [SerializeField]    float lowJumpMultiplier;
    [SerializeField]    bool jumpButtonPressed = false;
    [SerializeField]    bool sprintButtonPressed = false;

    [Header ("Physics")]
    [SerializeField]  Rigidbody2D rb;

    [Header("Scripts")]
    [SerializeField] ButtonsScript jumpButtonScipt;
    [SerializeField] ButtonsScript sprintButtonScipt;
    [SerializeField] Joystick joystick;



    // Start is called before the first frame update
    void Start()
    {
        speed = walk;
        bool sprintButtonPressed = sprintButtonScipt.sprintPresseed;
        bool jumpButtonPressed = jumpButtonScipt.jumpPressed;
    }

    // Update is called once per frame
    void Update()
    {
        JumpCurve();
        Walking();        
    }

    public void Walking()
    {
        x = joystick.Horizontal;
        rb.velocity = new Vector2(x * speed, 0) * Time.deltaTime;
        Sprinting();
    }

    public void Sprinting()
    {
        if(sprintButtonPressed == true)
        {
            speed = run;
        }
        else
        {
            speed = walk;
        }
    }

    public void Jumping()
    {
        rb.AddForce(new Vector2(0, jump));          
        
    }

    public void JumpCurve()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
    }
}
