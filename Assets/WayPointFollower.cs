
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WayPointFollower : MonoBehaviour
{
    private SteeringVehicle steeringVehicle;
    private WayPointManager wayPointManager;

    public static Action<Waypoint> waypointAction;

    private float margin = 1f;

    void Start()
    {
        steeringVehicle = GetComponent<SteeringVehicle>();
        wayPointManager = GetComponent<WayPointManager>();

        waypointAction += SetWaypointTarget;
        steeringVehicle.SetTarget(wayPointManager.GetFirstWayPoint().position);
    }

    void Update()
    {
        Waypoint _waypoint = wayPointManager.GetNextWayPoint();

        if (_waypoint == null)
            return;

        if (Vector2.Distance(transform.position, _waypoint.position) <= margin)
        {
            SetTarget(_waypoint);
        }
    }

    void FixedUpdate()
    {

    }

    void SetWaypointTarget(Waypoint _waypoint)
    {
        steeringVehicle.SetTarget(_waypoint.position);
    }


    void SetTarget(Waypoint _waypoint)
    {
        if (waypointAction == null)
        {
            print("No target found");
            return;
        }

        print("Target found");

        waypointAction(_waypoint);
    }

}
