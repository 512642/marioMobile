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
    public GameObject player;

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
        player.GetComponent<PlayerMechanics>().SetScore(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("load scene");
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
