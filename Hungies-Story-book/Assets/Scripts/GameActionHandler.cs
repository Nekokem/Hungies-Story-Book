﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public UnityEvent handlerEvent;
    public GameAction gameActionObj;

    private void Start()
    {
        gameActionObj.action += Action;
    }

    private void Action()
    {
        handlerEvent.Invoke();
    }
}
