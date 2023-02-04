using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;
    [SerializeField] private GameManager _gameManager;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    public void SetGameManager(GameManager manager)
    {
        _gameManager = manager;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    // checks which waterdrop hit the 'roots' first.
    // timeScale is used here to freeze/unfreeze everything so both don't end up 'winning'
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player Waterdrop"))
        {
            _gameManager.Win();
            Time.timeScale = 0.0f;
        }
        else
        {
            _gameManager.Lose();
            Time.timeScale = 0.0f;
        }
    }
}
