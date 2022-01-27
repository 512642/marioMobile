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
    Rigidbody2D rb;
    bool buttonSprintPressed;

    public Buttons buttonScript;
    // Start is called before the first frame update
    void Start()
    {        
     
        rb = GetComponent<Rigidbody2D>();
        saveSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        buttonSprintPressed = buttonScript.sprintPresseed;
        Running();
        Sprinting();
        Jumping();
    }
    
    void Running()
    {
        x = ReadX();
        rb.velocity = new Vector3(x * speed, 0, 0) * Time.deltaTime;
    }

    public void Sprinting()
    {
        if(buttonSprintPressed == true && x > 0.1)
        {
            
            speed = sprintSpeed;
            buttonSprintPressed = false;
        }
        else
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
    protected void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "death")
        {
            lives--;
        }
    }
    protected virtual float ReadX()
    {
        return Input.GetAxis("Horizontal");
    }


}
