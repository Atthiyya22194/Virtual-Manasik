using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onDoorwayTriggerEnter;
    public void DoorwayTriggerEnter(int id)
    {
        if (onDoorwayTriggerEnter != null)
        {
            onDoorwayTriggerEnter(id);
        }
    }

    /*public event Action onDoorwayTriggerExit;
    public void DoorwayTriggerExit()
    {
        if (onDoorwayTriggerExit != null)
        {
            onDoorwayTriggerExit();
        }
    }*/
}
