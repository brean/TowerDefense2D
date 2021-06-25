using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{
    public Vector3[] waypoints;

    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach (Transform child in transform) {
            i += 1;
        }
        waypoints = new Vector3[i];
        i = 0;
        foreach (Transform child in transform) {
            waypoints[i] = child.position;
            i += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
