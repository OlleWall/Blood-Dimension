using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    //N�r Esc trycks ner ska spelat pausas om det inte redan �r pausat f�r d� ska det startas igen. - Elsa
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    // Den h�r koden pausar respektive startar. 
    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Resume();
    }
    //sen om man klickar p� knappen som �r "exit to main menu" s� ska man bli skickad till main menu scenen.
}
