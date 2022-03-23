using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.Events;
using System;

//[RequireComponent(typeof(Rigidbody))]
//[RequireComponent(typeof(XRGrabInteractable))]
public class Weapon : MonoBehaviour
{
    //[SerializeField] protected float shootingForce;
    //[SerializeField] protected Transform bulletSpawn;
    //[SerializeField] private float recoilForce;
    //[SerializeField] private float damage;

  //  private Rigidbody rigidbody;
   // private XRGrabInteractable interactableWeapon;

    private XRGrabInteractable interactable = null;

    private void Awake()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    private void OnEnable()
    {
        interactable.activated.AddListener(Fire);

    }

    private void OnDisable()
    {
        interactable.activated.RemoveListener(Fire);
    }

    public void Fire(ActivateEventArgs interactable)
    {
        print("Fire");
    }

}
