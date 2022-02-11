using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void ReplayGame()
    {
        //Det här gör så att man blir förflyttad till leveln med replay knappen. - Elsa
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        //Det här gör så att man blir förflyttad till Main menu med quit knappen. - Elsa
        SceneManager.LoadScene("MainMenu");
    }

}