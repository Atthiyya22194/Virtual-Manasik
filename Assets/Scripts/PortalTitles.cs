using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTitles : MonoBehaviour
{
    public GameObject title;

    private void Start()
    {
        title.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            title.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        title.SetActive(false);
    }
}
