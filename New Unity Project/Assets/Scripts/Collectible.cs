
using System;
using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    public UnityEvent Event;
    public GameObject collectibleEffect;

    private void OnTriggerEnter(Collider other)
    {
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Debug.Log("HealthUp");
        Instantiate(collectibleEffect, transform.position, transform.rotation);
        Event.Invoke();
    }
}
