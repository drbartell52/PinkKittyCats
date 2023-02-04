using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameManager _gameManager;
    public GameObject winPanel;
    public GameObject losePanel;

    private void Awake()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }

    private void Update()
    {
        if (_gameManager.GetGameState() == GameState.Won)
        {
            SetWinPanels();
        }
        else if (_gameManager.GetGameState() == GameState.Lost)
        {
            SetLosePanels();
        }
        else
        {
            // reserve for gameplay
        }
    }

    public void SetLosePanels()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(true);
    }
    
    public void SetWinPanels()
    {
        winPanel.SetActive(true);
        losePanel.SetActive(false);
    }
}
