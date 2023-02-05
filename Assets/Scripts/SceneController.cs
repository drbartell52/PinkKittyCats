using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private LevelList levelList;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
    
    public void GoToNextLevel()
    {
        levelList.CurrentLevel++;
        if (levelList.CurrentLevel >= levelList.levels.Count)
        {
            // "True win" condition.
            // Should make a separate UI element that says all levels completed
            // and prompts user if they want to restart to the beginning or quit.
            levelList.CurrentLevel = 0;
        }

        SceneManager.LoadScene(levelList.levels[levelList.CurrentLevel]);
        Time.timeScale = 1.0f;
    }
    
}
