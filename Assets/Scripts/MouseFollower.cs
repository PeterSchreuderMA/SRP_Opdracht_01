using UnityEngine;
using System.Collections;

public class MouseFollower : MonoBehaviour
{

    private SteeringVehicle steeringVehicle;

    void Start()
    {
        steeringVehicle = GetComponent<SteeringVehicle>();


    }
    
    void FixedUpdate ()
    {
        // Als je met de muis klikt: geef dan aan SteeringVehicle door
        // via SetTarget() waar het vliegtuig naartoe moet
        steeringVehicle.SetTarget(GetMousePosition());
    }

    Vector2 GetMousePosition()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}