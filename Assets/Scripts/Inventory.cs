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
        // Det h�r g�r s� att n�r spelaren r�r ett object med tagen "Candle" och tangenten E trycks ner s� ska objectet f�rsvinna och playern ska gaina + 1 i score. - Elsa
        if (collision.gameObject.tag == "Candle" && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(collision.gameObject);
            score.PlayerScore += 1;
            
        }
    }
}