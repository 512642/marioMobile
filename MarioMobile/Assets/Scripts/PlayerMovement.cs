using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerMain
{
    float x;
    float speed;
    float saveSpeed = 750;
    float sprintSpeed = 1250;
    float jumpPower = 3000;
    Rigidbody2D rb;
    bool buttonSprintPressed;
    bool buttonJumpPressed;

    public Buttons buttonScript;
    // Start is called before the first frame update
    void Start()
    {             
        rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        print(rb.velocity.x);
        buttonSprintPressed = buttonScript.sprintPresseed;
        buttonJumpPressed = buttonScript.jumpPressed;
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
        if(buttonSprintPressed == true && rb.velocity.x > 0.8)
        {            
            speed = sprintSpeed;            
        }
        else
        {
            speed = saveSpeed;            
        }

    }
       void Jumping()
       {
           if(buttonJumpPressed == true)
           {
                rb.AddForce(Vector2.up * jumpPower);
               
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
