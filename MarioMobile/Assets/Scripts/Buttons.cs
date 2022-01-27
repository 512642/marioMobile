using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public bool sprintPresseed = false;
    public bool jumpPressed = false;
    public void jump()
    {
        jumpPressed = true;
    }
    public void Sprint()
    {
        sprintPresseed = true;
    }
}
