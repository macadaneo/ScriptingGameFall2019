using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public int counter = 10;
    private WaitForSeconds wfsObj;
    public float seconds = 1f;
    public bool canRun;
    public UnityEvent startEvent, repeatEvent, endEvent;
    
    
    
    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
    }

    public void CallCoroutine()
    {
        StartCoroutine(RunCoroutine());
    }
    
    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();
        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            Debug.Log(counter);
            counter--;
        }

        endEvent.Invoke();
        yield return wfsObj;
        Debug.Log("GO");
        
         while (canRun)
         {
             repeatEvent.Invoke();
             yield return wfsObj;
             Debug.Log(counter);
             counter--;
         }
         endEvent.Invoke();
         yield return wfsObj; 
         Debug.Log("GO");
    }
}
