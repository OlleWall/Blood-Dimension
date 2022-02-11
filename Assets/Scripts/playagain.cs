using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagain : MonoBehaviour
{
    public void PlayagainGame()
    //Det här gör så att man blir förflyttad till leveln med play again knappen. - Elsa
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    //Det här gör så att man blir förflyttad till main menu med quit knappen. - Elsa
    {
        SceneManager.LoadScene("MainMenu");
    }

}
