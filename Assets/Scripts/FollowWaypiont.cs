using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWaypiont : MonoBehaviour
{
    public WayPointManager wpm;
    public int nextWaypoint = 0;
    public Vector3 currentWaypoint;
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject path = GameObject.Find("Path");
        wpm = path.GetComponent<WayPointManager>();
        currentWaypoint = wpm.waypoints[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (nextWaypoint >= wpm.waypoints.Length) {
            return;
        }
        float step =  speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint, step);
        if (transform.position == currentWaypoint) {
            nextWaypoint += 1;
            if (nextWaypoint < wpm.waypoints.Length) {
                currentWaypoint = wpm.waypoints[nextWaypoint];
            }
        }
    }
}
