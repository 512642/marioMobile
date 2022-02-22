using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : PlayerMain
{
    public GameObject player;
    public PlayerMechanics playerMechanics;
    public Text livesText;
    // Update is called once per frame
    void FixedUpdate()
    {        
        string displayLives = playerMechanics.lives.ToString("F0");
        livesText.text = ("Lives: " + displayLives);
    }
}
