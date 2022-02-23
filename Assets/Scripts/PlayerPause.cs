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
    //När Esc trycks ner ska spelat pausas om det inte redan är pausat för då ska det startas igen. - Elsa
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
    // Den här koden pausar respektive startar. 
    public void ExitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Resume();
    }
    //sen om man klickar på knappen som är "exit to main menu" så ska man bli skickad till main menu scenen.
}
