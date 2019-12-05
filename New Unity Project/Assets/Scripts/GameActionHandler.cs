using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent handlerEvent;
    private void Start()
    {
        gameActionObj.action = RaiseHandler;
    }

    public void RaiseHandler()
    {
       handlerEvent.Invoke(); 
    }
}
