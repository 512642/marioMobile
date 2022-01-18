using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMain : MonoBehaviour
{
    protected float score = 0;
    protected float lives = 3;
    public Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {


        //Displays player score
    }

    protected void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "death")
        {
            lives--;
        }
    }
    protected virtual float ReadX()
    {
        return Input.GetAxis("Horizontal");
    }



}
