using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction GameActionObj;
    public UnityEvent HandlerEvent;
    private void Start()
    {
        GameActionObj.action = RaiseHandler;
    }

    public void RaiseHandler()
    {
       HandlerEvent.Invoke(); 
    }
}
