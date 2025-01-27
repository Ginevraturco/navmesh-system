﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class EventController : MonoBehaviour
{
    public UnityEvent enterAction;
    public UnityEvent exitAction;
    private void OnTriggerEnter(Collider other)
    {
        if (enterAction != null) enterAction.Invoke(); 
    }

    private void OnTriggerExit(Collider other)
    {
        if (exitAction != null) exitAction.Invoke();
    }

   
}
