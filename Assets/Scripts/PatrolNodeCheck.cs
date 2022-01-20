using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolNodeCheck : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -41)
        {
            transform.position = new Vector3(-40, 0, 0);
        }

        if (transform.position.x >= 38)
        {
            transform.position = new Vector3(37, 0, 0);
        }

        if (transform.position.y <= -37)
        {
            transform.position = new Vector3(0, -36, 0);
        }

        if (transform.position.y >= 33)
        {
            transform.position = new Vector3(0, 32, 0);
        }
    }
}
