using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void ReplayGame()
    {
        //Det h�r g�r s� att man blir f�rflyttad till leveln med replay knappen. - Elsa
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        //Det h�r g�r s� att man blir f�rflyttad till Main menu med quit knappen. - Elsa
        SceneManager.LoadScene("MainMenu");
    }

}