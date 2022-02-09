using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMain : MonoBehaviour
{
    protected float score = 0;
    protected float lives = 5;
    protected bool livesLeft;
    

    /*void OnCollisionEnter2D( Collision2D col )
    {
        if(col.gameObject.tag == "enemy" && livesLeft = true)
        {
            lives --;
        }
    }*/

    

    public void CheckForLives()
    {
        if(lives > 0)
        {
            livesLeft = true;
        }
        else 
        {
            livesLeft = false;
        }
    }




}
