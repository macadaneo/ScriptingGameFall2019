using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public UnityEvent repeatEvent;

    public void Run()
    {
        StartCoroutine(OnRun());
    }
    
    IEnumerator OnRun()
    {
        while (canRun)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(1f);
            Debug.Log("run");
            
        }
    }
}
