using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent triggerEvent;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }

}
