using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMain : MonoBehaviour
{
    protected float score;
    protected float lives;
    


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;
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
