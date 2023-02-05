using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Level List", menuName = "Level List / Create Level List", order = 0)]
public class LevelList : ScriptableObject
{
    public int CurrentLevel;

    public List<string> levels;

    public void GoToNextLevel()
    {
        CurrentLevel++;
        if (CurrentLevel >= levels.Count)
        {
            // "True win" condition.
            // Should make a separate UI element that says all levels completed
            // and prompts user if they want to restart to the beginning or quit.
            CurrentLevel = 0;
        }

        SceneManager.LoadScene(levels[CurrentLevel]);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartNewGame()
    {
        CurrentLevel = 0;
        SceneManager.LoadScene(levels[0]);
    }
}
