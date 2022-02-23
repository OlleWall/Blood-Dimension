using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Olle
public class cameraFollow : MonoBehaviour
{

    public GameObject cameraGO;

    // Update is called once per frame
    void Update()
    {
        cameraGO.transform.position = new Vector3(transform.position.x, transform.position.y, cameraGO.transform.position.z);
    }
}
