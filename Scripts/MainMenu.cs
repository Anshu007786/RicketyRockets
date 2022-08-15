using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void EndGame()
    {
        Application.Quit();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("0.MainM instructions");
    }
    public void BeginGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("1.Flyover");
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("00.LevelSelect");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("0.MainM");
    }
    
}
