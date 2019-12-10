using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Events;

public class ActionController : MonoBehaviour
{

    public float scaleSpeed = 10f;
    private Vector3 scales;
    private UnityAction transformAction;
    public GameAction action;
   
    
    
    public void IsScale()
    {
        scales.Set(scaleSpeed, scaleSpeed,scaleSpeed);
        transform.localScale += scales * Time.deltaTime;
    }

    public void Test()
    {
        Debug.Log("working??");
    }
    
}
