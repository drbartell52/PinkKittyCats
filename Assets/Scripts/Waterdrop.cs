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

    // TODO make GameManager handle freezing physics when one drop collides with goal
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Time.timeScale = 0.0f;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Time.timeScale = 1.0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        _gameManager.WaterDropMiss();
        Destroy(gameObject);
    }
}