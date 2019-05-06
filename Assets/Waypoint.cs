using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[System.Serializable]
public class Waypoint : MonoBehaviour
{

    public Vector2 position
    {
        get
        {
            return transform.position;
        }
    }
}
