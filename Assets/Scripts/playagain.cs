using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagain : MonoBehaviour
{
    public void PlayagainGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
