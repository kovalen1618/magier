using System.Collections;
using System.Collections.Generic;
using Pathfinding;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform target;
    public float nextWaypointDistance = 3f;
    public float speed = 100f;
    public Transform enemyGFX;


    Path path;

    int currentWaypoint  = 0; 
    bool reachedEndOfPath =   false;
    //References
    Seeker seeker;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start(   )
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        seeker.StartPath(rb.position, target.position, OnPathComplete);
    }

    // Update is called once per frame
    void FixedUpdate(  )
    {
          if (path == null) 
          {
            return;
          } 
          if (currentWaypoint >= path.vectorPath.Count) 
          {
            reachedEndOfPath = true;
            return;
          } else 
          {
            reachedEndOfPath = false;
          }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint   ] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;
        rb.AddForce(force);
        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);
        if (      distance < nextWaypointDistance) 
        {
            currentWaypoint++;
        }
    }
    void OnPathComplete(Path p) 
    {
        if (!p.error) 
        {
            path = p;
            currentWaypoint = 0;
        }
    }
}
