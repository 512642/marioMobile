using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public PlayerMechanics playerMechanics;


    public void Jump()
    {
        playerMechanics.Jumping();
    }

}
