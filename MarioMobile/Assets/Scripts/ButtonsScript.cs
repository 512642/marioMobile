using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsScript : MonoBehaviour
{
    public bool jumpPressed = false;
    public GameObject jumpButton;
    public PlayerMechanics playerMechanics;
    PlayerMain playerMain;

    public void Start()
    {
        playerMain = GetComponent<PlayerMain>();
    }

    public void Jump()
    {
        playerMechanics.Jumping();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
