using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpAnim : MonoBehaviour
{
    public UnityEvent inputEvent;
    public string inputWord;

    private void Update()
    {
        if (Input.GetButtonDown(inputWord))
        {
            inputEvent.Invoke();
        }
    }
}
