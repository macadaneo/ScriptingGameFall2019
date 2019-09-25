
using System;
using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    public UnityEvent Event;
    public GameObject collectibleEffect;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("HealthUp");
            Instantiate(collectibleEffect, transform.position, transform.rotation);
            Event.Invoke();
            Destroy(gameObject);
    }
}
