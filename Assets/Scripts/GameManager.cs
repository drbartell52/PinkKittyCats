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
        Debug.Log("Miss!");
        lives--;
        if (lives == 0)
        {
            Debug.Log("game over");
            _gameState = GameState.Lost;
        }
        else
        {
            SpawnWaterDrop();
        }
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
