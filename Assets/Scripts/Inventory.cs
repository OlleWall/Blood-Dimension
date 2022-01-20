using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Score score;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Candle" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            score.PlayerScore += 1;
            
        }
    }
}