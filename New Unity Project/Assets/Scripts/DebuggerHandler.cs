using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggerHandler : MonoBehaviour
{
    public Debugger debuggerObj;

    private void Start()
    {
        debuggerObj.OnDebug();
    }

    public void Update()
    {
        debuggerObj.OnDebug();
    }
}