using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame ()
    {
        //Det h�r g�r s� att man blir f�rflyttad till leveln med play knappen. - Elsa
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame ()
    {
        //Det h�r st�nger ner spelet/builden helt. - Elsa
        Application.Quit();
    }
        
}
