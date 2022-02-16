using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMain : MonoBehaviour
{
    protected float score = 0;
    protected float lives = 5;

    public void LoselLife()
    {
        lives--;
    }



}
