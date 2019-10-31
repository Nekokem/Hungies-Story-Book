using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ToggleLights : MonoBehaviour
{
   public UnityEvent lightsOneEvent;
   public UnityEvent lightsOffEVent;

   public bool onAndOff;

   public void Toggle()
   {
      if (onAndOff == true)
      {
         lightsOneEvent.Invoke();
         onAndOff = false;
      }
      else
      {
         lightsOffEVent.Invoke();
         onAndOff = true;
      }
   }
}
