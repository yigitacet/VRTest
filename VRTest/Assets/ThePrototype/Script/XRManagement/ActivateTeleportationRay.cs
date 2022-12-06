using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
   [SerializeField] private GameObject leftTeleportation;
   [SerializeField] private GameObject rightTeleportation;

   [SerializeField] private InputActionProperty leftActivate;
   [SerializeField] private InputActionProperty rightActivate;

   private void Update()
   {
      leftTeleportation.SetActive(leftActivate.action.ReadValue<float>()> 0.1f);
      rightTeleportation.SetActive(rightActivate.action.ReadValue<float>()> 0.1f);
   }
}
