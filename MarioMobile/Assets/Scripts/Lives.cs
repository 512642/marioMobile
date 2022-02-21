using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : PlayerMain
{
    public Text livesText;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Displays player lives while the player has any left.
        livesText.text = ("Lives: " + displayLives);
              
            
        
    }
}
