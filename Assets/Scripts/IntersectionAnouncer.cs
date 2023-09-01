using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntersectionAnouncer : MonoBehaviour
{
    public VehicleTrigger vehicleTrigger;
    public PlayerStatusText playerStatusText;
    // Start is called before the first frame update
    public string text;
    void Start()
    {
        vehicleTrigger.playerEntered += sendMsg;
    }
    

    void sendMsg(object a, EventArgs args)
    {
        playerStatusText.AddAnnouncement(text);
    }
    
    
}
