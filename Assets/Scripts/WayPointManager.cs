using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointManager : MonoBehaviour
{
    [SerializeField]
    private List<Transform> wayPoints = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        FillList();
    }

    void FillList()
    {
        foreach (var item in FindObjectsOfType<GameObject>())
        {
            if (item.tag == "Waypoint")
                wayPoints.Add(item.transform);
        }
    }

    public Transform GetFirstWayPoint()
    {
        if (wayPoints.Count == 0) return null;
        return wayPoints[0];
    }
}
