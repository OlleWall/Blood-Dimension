using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playagain : MonoBehaviour
{
    public void PlayagainGame()
    //Det h�r g�r s� att man blir f�rflyttad till leveln med play again knappen. - Elsa
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    //Det h�r g�r s� att man blir f�rflyttad till main menu med quit knappen. - Elsa
    {
        SceneManager.LoadScene("MainMenu");
    }

}
