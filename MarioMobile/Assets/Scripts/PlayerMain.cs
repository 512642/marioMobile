using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMain : MonoBehaviour
{
    public float score = 0;
    int scorePerSecond;
    public string displayScore;

    public void Update()
    {
        GetPoints();
    }
    public void GetPoints()
    {
        score = scorePerSecond * Time.time;
        displayScore = score.ToString("F0");
        scorePerSecond = 10;
    }

}
