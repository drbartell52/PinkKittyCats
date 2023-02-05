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
        SceneManager.LoadScene(levelList.levels[levelList.CurrentLevel]);
        Time.timeScale = 1.0f;
    }
    
    public void BackButton()
    {
        // if this doesnt work hardcode it to whatever scene the title is
        levelList.CurrentLevel = 0;
        SceneManager.LoadScene(levelList.levels[levelList.CurrentLevel]);
    }
    
    public void HowToButton()
    {
        // if this doesnt work hardcode it to whatever scene the title is
        levelList.CurrentLevel = 4;
        SceneManager.LoadScene(levelList.levels[levelList.CurrentLevel]);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
