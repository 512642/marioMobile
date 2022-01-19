using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public bool jumpPressed = false;
    public bool sprintPressed = false;

    public void jump()
    {
        jumpPressed = true;
    }
    public void Sprint()
    {
        sprintPressed = true;
    }
}
