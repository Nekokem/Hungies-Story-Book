using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    private void OnTriggerEnter(Collider trig)
    {
        Destroy(gameObject);
    }
}
