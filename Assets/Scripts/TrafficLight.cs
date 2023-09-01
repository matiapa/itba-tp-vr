using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TrafficLightPhase
{
    Red,
    Yellow,
    Green
}
public class TrafficLight : MonoBehaviour
{

    private TrafficLightPhase _phase;
    public PlayerStatusText feedbackText;
    public VehicleTrigger redLightTrigger;
    public GameObject RedOverlay;
    public GameObject YellowOverlay;
    public GameObject GreenOverlay;

    private void Start()
    {
        redLightTrigger.playerEntered += OnPlayerCrossRed;
    }

    private void OnDestroy()
    {
        redLightTrigger.playerEntered -= OnPlayerCrossRed;
    }

    public void SetPhaseTo(TrafficLightPhase phase)
    {
        _phase = phase;
        RedOverlay.SetActive(false);
        YellowOverlay.SetActive(false);
        GreenOverlay.SetActive(false);
        switch (phase)
        {
            case TrafficLightPhase.Red:
                RedOverlay.SetActive(true);
                break;
            case TrafficLightPhase.Yellow:
                YellowOverlay.SetActive(true);
                break;
            case TrafficLightPhase.Green:
                GreenOverlay.SetActive(true);
                break;

        }
    }

    private void OnPlayerCrossRed(object sender, EventArgs args)
    {
        if (_phase == TrafficLightPhase.Red)
        {
            feedbackText.AddAnnouncement("Crucasete una intersección en rojo!");
        }
    }
    
}
