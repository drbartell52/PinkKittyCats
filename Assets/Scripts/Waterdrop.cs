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

    private void OnTriggerEnter2D(Collider2D col)
    {
        _gameManager.WaterDropMiss();
        Destroy(gameObject);
    }
}