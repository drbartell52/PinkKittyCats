using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public GameObject playerDropPrefab;
    public GameObject enemyDropPrefab;
    private GameState _gameState;
    [SerializeField] private int lives;
    [SerializeField] private LevelList levelList;
    // range one should be minimum X value,
    // range two should be maximum X value
    public float enemyDropRangeOne;
    public float enemyDropRangeTwo;
    public GameObject enemyDropBucket;
    void Start()
    {
        _gameState = GameState.Playing;
        SpawnWaterDrop(playerDropPrefab);
        SpawnEnemyDropAndBucket(enemyDropPrefab);
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
            SpawnWaterDrop(playerDropPrefab);
        }
    }

    public void Lose()
    {
        if (_gameState != GameState.Won)
        {
            _gameState = GameState.Lost;
        }
    }

    public void Win()
    {
        _gameState = GameState.Won;
    }

    
    private void SpawnWaterDrop(GameObject prefab)
    {
        if (_gameState == GameState.Playing)
        {
            GameObject waterdropObject = Instantiate(prefab);
            Waterdrop drop = waterdropObject.GetComponent<Waterdrop>();
            drop.SetGameManager(this);
        }
    }
    
    // code smell: this probably shouldn't need its own function just to enable random position
    private void SpawnEnemyDropAndBucket(GameObject prefab)
    {
        if (_gameState == GameState.Playing)
        {
            Vector3 position = new Vector3(Random.Range(enemyDropRangeOne, enemyDropRangeTwo),0,0);
            GameObject enemyDropObject = Instantiate(prefab, position, Quaternion.identity);
        }
    }
    
    
    // LEVEL TESTING PLEASE REMOVE LATER
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            levelList.GoToNextLevel();
        }
    }
}
