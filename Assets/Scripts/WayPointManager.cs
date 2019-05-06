using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{
    [SerializeField]
    private List<Waypoint> wayPoints = new List<Waypoint>();

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Awake()
    {
        FillList();
        WayPointFollower.waypointAction += InitNextWaypoint;
    }

    void FillList()
    {
        foreach (var item in FindObjectsOfType<Waypoint>())
        {
            if (item.tag == "Waypoint")
                wayPoints.Add(item);
        }
    }

    public Waypoint GetFirstWayPoint()
    {
        if (wayPoints.Count == 0) return null;
        return wayPoints[0];
    }

    public Waypoint GetNextWayPoint()
    {
        return wayPoints[currentIndex];
    }

    void InitNextWaypoint(Waypoint _waypoint)
    {
        currentIndex++;

        currentIndex = currentIndex % wayPoints.Count;

        print(currentIndex);
    }
}
