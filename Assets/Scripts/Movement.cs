using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    public void Run(float horizontal)
    {
        //Takes float as parameter and moves the GameObject horizontally based on float value
        
        Vector2 movement = new Vector2(horizontal, 0);
        _rigidbody2D.AddForce(movement);
    }

}
