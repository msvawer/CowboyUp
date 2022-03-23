using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    private XRGrabInteractable interactable = null;
    public GameObject laserprefab;

    public float damage = 10f;
    public float hitRange = 100f;

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(laserprefab.transform.position, laserprefab.transform.forward, out hit, hitRange))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
