using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : PlayerMain
{
    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Displays player lives while the player has any left.
        while (lives > 0)
        {
            livesText.text = ("Lives: " + lives);
        }
    }
}
