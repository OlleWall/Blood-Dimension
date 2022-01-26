using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMover : MonoBehaviour
{
    [SerializeField, Range(1, 50)]
    float speed = 5;

    public Vector2 facing;

    public Vector2 moveDirection;

    public SpriteMask flashLight;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //player movment -Olle
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection.y = 1;
            facing.y = 1;
        } 
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection.y = -1;
            facing.y = -1;
        }
        else
        {
            moveDirection.y = 0;
            facing.y = 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x = 1;
            facing.x = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x = -1;
            facing.x = -1;
        }
        else
        {
            moveDirection.x = 0;
            facing.x = 0;
        }

        Move(moveDirection);

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

    void Move(Vector2 vector)
    {
        rb.velocity = vector.normalized * speed;
    }

    void Death()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Death();
    }
}

