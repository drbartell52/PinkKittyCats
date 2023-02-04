using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerDropPrefab;
    public GameObject enemyDropPrefab;
    private GameState _gameState;
    private int lives;
    void Start()
    {
        _gameState = GameState.Playing;
        SpawnWaterDrop();
    }

    public GameState GetGameState()
    {
        return _gameState;
    }

    // called by player waterdrop when it goes out of bounds
    public void WaterDropMiss()
    {
        lives--;
        if (lives == 0)
        {
            _gameState = GameState.GameOver;
        }
        else
        {
            SpawnWaterDrop();
        }
    }

    public void Lose()
    {
        _gameState = GameState.Lost;
    }

    public void Win()
    {
        _gameState = GameState.Won;
    }

    
    private void SpawnWaterDrop()
    {
        if (_gameState == GameState.Playing)
        {
            GameObject waterdropObject = Instantiate(playerDropPrefab);
            Waterdrop drop = waterdropObject.GetComponent<Waterdrop>();
            drop.SetGameManager(this);
        }
    }
}
