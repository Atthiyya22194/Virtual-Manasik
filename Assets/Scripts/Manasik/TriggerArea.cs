using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class TriggerArea : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameEvents.current.DoorwayTriggerEnter(id);
        }
    }

    /*private void OnTriggerExit(Collider other)
    {
        GameEvents.current.onDoorwayTriggerExit();
    }*/
}
