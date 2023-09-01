using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleTrigger : MonoBehaviour
{
    public event EventHandler playerEntered;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        EventHandler handler = playerEntered;
        handler.Invoke(this,EventArgs.Empty);
    }
}
