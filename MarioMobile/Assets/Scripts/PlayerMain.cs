using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMain : MonoBehaviour
{
    protected float score = 0;
    int scorePerSecond = 10;
    public string displayScore;
    public string displayLives;
    protected float lives = 5;
    public void Update()
    {
        GetPoints();
        GetLives();
    }
    public void LoseLife()
    {
        lives--;
    }

    public void GetLives()
    {
        displayLives = lives.ToString("F0");
    }
    public void GetPoints()
    {        
        score = scorePerSecond * Time.time;
        displayScore = score.ToString("F0");
    }


}
