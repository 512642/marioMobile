using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    public bool sprintPresseed = false;
    public bool jumpPressed = false;
    public GameObject jumpButton;
    public GameObject sprintButton;

    private void Update()
    {
       
    }
    public void Jump()
    {
        jumpPressed = true;
    }
    public void Sprint()
    {
        sprintPresseed = true;
    }
}
