﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent startEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        startEvent.Invoke();
    }
    
}
