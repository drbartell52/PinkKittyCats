using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterdrop : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    private GameManager _gameManager;
    private bool isFalling;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update

    public void SetGameManager(GameManager manager)
    {
        _gameManager = manager;
    }

    void Start()
    {
        isFalling = false;
    }

    // destroys the waterdrop if it goes off screen.
    // it should be almost impossible to not do this deliberately in the game lol
    private void OnTriggerEnter2D(Collider2D col)
    {
        _gameManager.WaterDropMiss();
        Destroy(gameObject);
    }
}