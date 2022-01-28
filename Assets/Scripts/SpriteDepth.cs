using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDepth : MonoBehaviour
{

    public Transform player;


    [SerializeField, Range(0, 5)]
    private float offset;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > transform.position.y - offset)
        {
            spriteRenderer.sortingOrder = 3;
        }
        else
        {
            spriteRenderer.sortingOrder = 1;
        }
    }
}
