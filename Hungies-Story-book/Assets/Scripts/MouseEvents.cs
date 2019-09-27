using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseClickDownEvent;

    public void OnMouseDown()
    {
        Debug.Log("mouse down");
        mouseClickDownEvent.Invoke();
    }
}
