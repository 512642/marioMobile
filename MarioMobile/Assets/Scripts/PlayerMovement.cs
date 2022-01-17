using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerMain
{
    float x;
    float speed = 750;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = ReadX();
        rb.velocity = new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }

    
}
