
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    private SteeringVehicle steeringVehicle;
    private WayPointManager wayPointManager;


    private Vector2 GetNextWayPoint()
    {

        steeringVehicle.SetTarget(wayPointManager.GetFirstWayPoint());
    }



}
