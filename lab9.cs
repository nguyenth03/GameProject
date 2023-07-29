using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
   //drag to MovingPlatform
    public GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    public float speed = 2f;

    void Update()
    {
        if(Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
///

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
   private void OnTriggerEnter2D(Collection2D collision)
   {
    if(collision.gameObject.name == "Player")// same name object
    {
        collision.gameObject.transform.SetParent(transform);
    }
   }

   private void OnTriggerEnter2D(Collection2D collision)
   {
    if(collision.gameObject.name == "Player")
    {
        collision.gameObject.transform.SetParent(null);
    }
   }

}