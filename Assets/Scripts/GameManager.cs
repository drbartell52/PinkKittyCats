using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerDropPrefab;
    public GameObject enemyDropPrefab;
    private GameState _gameState;
    // Start is called before the first frame update
    void Start()
    {
        _gameState = GameState.Playing;
        SpawnWaterDrop();
    }

    public GameState GetGameState()
    {
        return _gameState;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WaterdropFindRoot()
    {
        _gameState = GameState.Won;
        Debug.Log("win.");
    }
    private void SpawnWaterDrop()
    {
        if (_gameState == GameState.Playing)
        {
            GameObject waterdropObject = Instantiate(playerDropPrefab);
        }
    }
}
