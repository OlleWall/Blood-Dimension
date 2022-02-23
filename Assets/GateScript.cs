using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    //Olle
    bool doorOpen = false;
    public float timer;
    [SerializeField]
    GameObject Gate;
    [SerializeField]
    BoxCollider2D Bc;
    [SerializeField]
    SpriteRenderer Sr;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (doorOpen == true)
        {
            Destroy(Bc);
            Destroy(Sr);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            doorOpen = true;
            print("Door opened");
            Debug.Log("Door Opened");
        }
       
    }

}
