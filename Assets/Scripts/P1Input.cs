using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Input : MonoBehaviour
{
    private Movement _movement;

    void Start()
    {
        _movement = GetComponent<Movement>();
        //collects functions from PlayerController script
    }


    void Update()
    {
        //Collects data from user input and calls player controller function 'Run' to move the GameObject
        float horizontal = Input.GetAxisRaw("Horizontal");

        _movement.Run(horizontal);
    }
}
