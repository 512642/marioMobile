using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : PlayerMain
{

    public GameObject player;
    public Text scoreText;

    // Update is called once per frame
    void FixedUpdate()
    {
        scoreText.text = ("Score: " + displayScore);
    }
}
