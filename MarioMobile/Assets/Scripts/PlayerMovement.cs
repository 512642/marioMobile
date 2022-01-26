using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerMain
{
    float x;
    float speed = 750;
    float saveSpeed;
    float sprintSpeed = 1250;
    float jumpPower = 600;
    bool buttonSprintPressed;

    Buttons buttonScript;

    
    // Start is called before the first frame update
    void Start()
    {
        buttonScript = GetComponent<Buttons>();
        buttonSprintPressed = buttonScript.sprintPressed;
        saveSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        Running();
        Sprinting();
        Jumping();
    }

    void Running()
    {
        x = ReadX();
        rb.velocity = new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }

    void Sprinting()
    {
        if(buttonSprintPressed == true)
        {
            Running();
            speed = sprintSpeed;
            buttonSprintPressed = false;
        }

    }
    void StopSprinting()
    {
        if(rb.velocity.x < 10)
        {
            speed = saveSpeed;            
        }
    }
       void Jumping()
       {
           if(buttonSprintPressed == true)
           {
               rb.velocity += new Vector2(0, jumpPower);
               buttonSprintPressed = false;
           }
       }


    
}
