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

    Buttons buttonScript;
    // Start is called before the first frame update
    void Start()
    {
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
        if(buttonScript.sprintPressed == true)
        {
            speed = sprintSpeed;
            Running();
        }

        StopSprinting();
    }
    void StopSprinting()
    {
        if(rb.velocity.x < 10)
        {
            speed = saveSpeed;
            buttonScript.sprintPressed = false;
        }
    }
       void Jumping()
       {
           if(buttonScript.jumpPressed == true)
           {
               rb.velocity += new Vector2(0, jumpPower);
               buttonScript.jumpPressed = false;
           }
       }


    
}
