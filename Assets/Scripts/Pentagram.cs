using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pentagram : MonoBehaviour
{

    Score score;

    int lights = 0;

    public SpriteRenderer ljus1;
    public SpriteRenderer ljus2;
    public SpriteRenderer ljus3;
    public SpriteRenderer ljus4;
    public SpriteRenderer ljus5;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && score.PlayerScore > lights)
        {
            if (Light(ljus1, 1) && Light(ljus2, 2) && Light(ljus3, 3) && Light(ljus4, 4) && Light(ljus5, 5))
            {
                SceneManager.LoadScene("playagain", LoadSceneMode.Single);
            }
        }
    }

    bool Light(SpriteRenderer light, int neededScore)
    {
        if (score.PlayerScore >= neededScore)
        {
            light.enabled = true;
            return true;
        }
        else
        {
            light.enabled = false;
            return false;
        }
    }
}
