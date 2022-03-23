using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Gun : MonoBehaviour
{
    private XRGrabInteractable interactable = null;

    public float damage = 10f;
    public float range = 100f;

    public void Fire()
    {
        print("Fire");
    }
}
