using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterdropHolderMovement : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody2D _rigidbody2D;
    private float movement;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // everything in Update() and FixedUpdate() controls the movement of the holder
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        // will only move if GameState is Playing
        if (gameManager.GetGameState() == GameState.Playing)
        {
            Vector2 delta = new Vector2(movement * Time.fixedDeltaTime * speed, 0);
            _rigidbody2D.MovePosition(_rigidbody2D.position + delta);
        }
    }
}
