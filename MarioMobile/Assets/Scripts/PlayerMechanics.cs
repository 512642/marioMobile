using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    [Header ("Player Variables")]
    [SerializeField] float walk;
    [SerializeField] float run = 2000;
    [SerializeField] float saveWalk = 1000;
    [SerializeField] float jump = 1000;
    [SerializeField] bool jumpButtonPressed = false;
    [SerializeField] bool sprintButtonPressed = false;

    [Header ("Physics")]
    [SerializeField]  Rigidbody2D rb;

    [Header("Scripts")]
    [SerializeField] ButtonsScript jumpButtonScipt;
    [SerializeField] ButtonsScript sprintButtonScipt;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
