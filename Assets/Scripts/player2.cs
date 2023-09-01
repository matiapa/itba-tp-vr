using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    [Header("Required Prefabs")]
    public VehicleController vehicleController;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vehicleController.UpdateSteeringFixedUpdate(
            Input.GetAxis("Vertical"),
            Input.GetAxis("Horizontal"));
    }
}
