using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pentagram : MonoBehaviour
{

    Score score;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && score.PlayerScore >= 5)
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}
