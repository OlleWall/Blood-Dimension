using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMover : MonoBehaviour
{
    [SerializeField, Range(1, 50)]
    float speed = 5;

    public Vector2 facing;

    public SpriteMask flashLight;

    Score score;

    // Update is called once per frame
    void Update()
    {
        //player movment -Olle
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, speed, 0) * Time.deltaTime;
            facing.y = 1;
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;
            facing.y = -1;
        }
        else
        {
            facing.y = 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
            facing.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
            facing.x = -1;
        }
        else
        {
            facing.x = 0;
        }

        //när ctrl trycks ner pekar objektet musen
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //skapar en vector3 med musens kordinater -Olle
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // räknar ut delta x och y för att skapa en vector mot musen -Olle
            facing = new Vector2
                (
                mousePosition.x - transform.position.x,
                mousePosition.y - transform.position.y
                );
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (flashLight.enabled == false)
            {
                flashLight.enabled = true;
            }
            else
            {
                flashLight.enabled = false;
            }
        }

        //när spelarn börjar gå nollställer facing -Olle
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftControl))
        {
            transform.up = facing;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        }
    }
}

