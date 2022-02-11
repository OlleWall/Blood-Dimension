using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    Score score;

    private void Start()
    {
        //Hittar score - Elsa
        score = FindObjectOfType<Score>();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // Det här gör så att när spelaren rör ett object med tagen "Candle" och tangenten E trycks ner så ska objectet försvinna och playern ska gaina + 1 i score. - Elsa
        if (collision.gameObject.tag == "Candle" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            score.PlayerScore += 1;
            
        }
    }
}