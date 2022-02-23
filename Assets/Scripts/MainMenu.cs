using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void PlayGame ()
    {
        //Det här gör så att man blir förflyttad till leveln med play knappen. - Elsa
        SceneManager.LoadScene("Level");
    }
    
    public void QuitGame ()
    {
        //Det här stänger ner spelet/builden helt. - Elsa
        Application.Quit();
    }
        
}
