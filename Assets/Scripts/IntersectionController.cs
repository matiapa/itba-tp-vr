using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public enum IntersectionCycle
{
    Street1,
    Street2,
    Wait1,
    Wait2
}
public class IntersectionController : MonoBehaviour
{
    // Start is called before the first frame update

    private IntersectionCycle currentCycle = IntersectionCycle.Street1;
    private float timer = 0;
    public List<TrafficLight> street1;
    public List<TrafficLight> street2;

    public float redGreenCycle = 20;
    public float yellowCycle = 3;
    void Start()
    {
        timer = 0;
        currentCycle = IntersectionCycle.Street1;
    }

    private void _applyTrafficLightToStreet(List<TrafficLight> street, TrafficLightPhase phase)
    {
        foreach (var trafficLight in street)
        {
            trafficLight.SetPhaseTo(phase);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer <= 0)
        {
            switch (currentCycle)
            {
                case IntersectionCycle.Street1:
                    _applyTrafficLightToStreet(street1,TrafficLightPhase.Green);
                    _applyTrafficLightToStreet(street2,TrafficLightPhase.Red);
                    timer = redGreenCycle;
                    currentCycle = IntersectionCycle.Wait1;
                    break;
                
                case IntersectionCycle.Street2:
                    _applyTrafficLightToStreet(street1,TrafficLightPhase.Red);
                    _applyTrafficLightToStreet(street2,TrafficLightPhase.Green);
                    timer = redGreenCycle;
                    currentCycle = IntersectionCycle.Wait2;
                    break;
                
                case IntersectionCycle.Wait1:
                    _applyTrafficLightToStreet(street1,TrafficLightPhase.Yellow);
                    _applyTrafficLightToStreet(street2,TrafficLightPhase.Yellow);
                    timer = yellowCycle;
                    currentCycle = IntersectionCycle.Street2;
                    break;
                
                case IntersectionCycle.Wait2:
                    _applyTrafficLightToStreet(street1,TrafficLightPhase.Yellow);
                    _applyTrafficLightToStreet(street2,TrafficLightPhase.Yellow);
                    timer = yellowCycle;
                    currentCycle = IntersectionCycle.Street1;
                    break;

            }
        }
        else
        {
            timer -= Time.deltaTime;
        }            
    }
}
