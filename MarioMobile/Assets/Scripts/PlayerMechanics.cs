using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    [Header("Player Variables")]
    [SerializeField]    float x;
    [SerializeField]    float speed;
    [SerializeField]    float walk = 1000;
    [SerializeField]    float run = 2000;
    [SerializeField]    float jump = 10;
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
        Walking();
        Sprinting();
        Jumping();
    }

    public void Walking()
    {
        x = joystick.Horizontal;
        rb.velocity = new Vector2(x * speed, 0) * Time.deltaTime;
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
        if(jumpButtonPressed == true)
        {
            rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }        
    }
}
