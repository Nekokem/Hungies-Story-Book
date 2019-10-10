using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.Events;

public class ActionControler : MonoBehaviour
{

    public float speed = 0.5f, scaleSpeed = 10f, rotationSpeed = 10f;
    private Vector3 location, scales, rotationLocation;
    private UnityAction transformAction;
    public Color hungeesColor;
    


    public void IsMove()
    {
        location.x = speed * Time.deltaTime;
        transform.Translate(location);
    }

    public void IsScale()
    {
        scales.Set(scaleSpeed, scaleSpeed,scaleSpeed);
        transform.localScale += scales * Time.deltaTime;
    }

    public void IsRotation()
    {
        rotationLocation.y = rotationSpeed * Time.deltaTime;
    }

    public void ColorChange()
    {
        
    }
}
