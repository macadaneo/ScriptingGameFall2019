using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class DistructibleEnv : MonoBehaviour
{
  public UnityEvent Event;
  public bool Distructable = false;
  private ParticleSystem rubble;
  private void OnTriggerEnter(Collider other)
  {
    Distructable = true;
  }

  private void OnTriggerExit(Collider other)
  {
    Distructable = false;
  }

  private void OnDestroy()
  {
    Instantiate(rubble, transform.position, transform.rotation);
    Destroy(rubble);
  }
}
