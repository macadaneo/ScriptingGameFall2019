using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
    public UnityEvent lightOff;
    private void OnMouseDown()
    {
        lightOff.Invoke();
    }
}
