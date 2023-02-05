using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleUIManager : MonoBehaviour
{
    // code smell: this whole script is basically just SceneController
    [SerializeField] private LevelList levelList;

    void Start()
    {
        levelList.CurrentLevel = 0; 
    }
    public void StartGame()
    {
        levelList.CurrentLevel++;
        // if (levelList.CurrentLevel >= levelList.levels.Count)
        // {
        //     levelList.CurrentLevel = 0;
        // }
        SceneManager.LoadScene(levelList.levels[levelList.CurrentLevel]);
        Time.timeScale = 1.0f;
    }
}
