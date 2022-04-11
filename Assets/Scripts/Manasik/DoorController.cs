using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DoorController : MonoBehaviour
{
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        //GameEvents.current.onDoorwayTriggerEnter += OnDoorwayClose;
    }

    private void OnDoorwayOpen(int id)
    {
        if (id == this.id)
        {
            id += 1;
            PhotonNetwork.LoadLevel(id);
            Debug.LogFormat("PhotonNetwork : Loading Map Kaaba");
        }
    }

    /*private void OnDoorwayClose()
    {
        for next time when you need something to finish
    }*/

    private void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= OnDoorwayOpen;
    }
}
