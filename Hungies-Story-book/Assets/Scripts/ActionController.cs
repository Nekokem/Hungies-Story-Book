using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Events;

public class ActionController : MonoBehaviour
{

    public float speed = 0.5f, scaleSpeed = 10f, rotationSpeed = 10f;
    private Vector3 scales;
    private UnityAction transformAction;
   
    
    
    public void IsScale()
    {
        scales.Set(scaleSpeed, scaleSpeed,scaleSpeed);
        transform.localScale += scales * Time.deltaTime;
    }

}
