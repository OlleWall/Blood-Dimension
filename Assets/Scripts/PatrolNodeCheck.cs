using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Olle
public class PatrolNodeCheck : MonoBehaviour
{

    EnemyAI enemy;

    private void Start()
    {
        enemy = FindObjectOfType<EnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -41)
        {
            transform.position = new Vector3(-40, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= 38)
        {
            transform.position = new Vector3(37, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= -37)
        {
            transform.position = new Vector3(transform.position.x, -36, transform.position.z);
        }

        if (transform.position.y >= 33)
        {
            transform.position = new Vector3(transform.position.x, 32, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            print("???");
            enemy.Patrol();
        }
    }
}
