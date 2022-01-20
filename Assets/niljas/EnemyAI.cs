using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    Vector3 min;
    Vector3 max;
    [SerializeField, Range(0, 50)]
    float areaSize;
    public GameObject player;
    public GameObject patrolNode;
    Vector2 playerDirection;

    AIDestinationSetter setter;

    AudioManager manager;
    

    // Start is called before the first frame update
    void Start()
    {
        setter = GetComponent<AIDestinationSetter>();
        manager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = new Vector2
            (
            player.transform.position.x - transform.position.x,
            player.transform.position.y - transform.position.y
            );

        RaycastHit2D hit = Physics2D.Raycast(transform.position, playerDirection);

        if (hit.transform != null && hit.distance < 10 && hit.collider.gameObject.tag == "Player")
        {
            setter.target = hit.transform;
            manager.Play("Chase");
            print("Played audio and raycast got close enough");
        } 
        else if (Vector3.Distance(transform.position, hit.transform.position) > 10)
        {
            setter.target = patrolNode.transform;
        }
        else if (Vector3.Distance(transform.position, patrolNode.transform.position) < 1)
        {          
            Patrol();
        }
        
        
        if(hit.transform != null && hit.distance > 10 && hit.collider.gameObject.tag == "Player")
        {
            manager.Stop("Chase");
            print("stopped chase audio");
        }
    }

    void Patrol()
    {
        min = player.transform.position - new Vector3(-areaSize, -areaSize, 0);
        max = player.transform.position - new Vector3(areaSize, areaSize, 0);

        patrolNode.transform.position = new Vector3(Random.Range(min.x, max.x), Random.Range(min.y, max.y), 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Patrol")
        {
           Patrol();
        }
    }
}
