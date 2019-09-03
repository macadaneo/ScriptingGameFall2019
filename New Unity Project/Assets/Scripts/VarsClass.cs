using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VarsClass : MonoBehaviour
{

    public float floatValue;
    public int intValue;
    public string stringValue = "bob";
    public int firePower;
    public UnityEvent Event;
    
    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
