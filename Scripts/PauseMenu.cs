using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{   
    public static bool isPaused = false;

    public GameObject pauseMenuUI;
    public GameObject canvasUI;

    private void Start() 
    {
        isPaused = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        canvasUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        canvasUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("0.MainM");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
