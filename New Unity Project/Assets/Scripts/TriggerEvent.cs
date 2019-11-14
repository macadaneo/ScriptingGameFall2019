using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent startEvent, endEvent;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        startEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        endEvent.Invoke();
    }
}
