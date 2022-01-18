using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerMain
{
    float x;
    float speed = 750;
    float saveSpeed;
    float sprintSpeed = 1250;
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
    }

    void Running()
    {
        x = ReadX();
        rb.velocity = new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }

    void Sprinting()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        else
        {
            speed = saveSpeed;
        }

       
    }

    
}
