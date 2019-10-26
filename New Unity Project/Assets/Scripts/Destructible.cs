using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class Destructible : MonoBehaviour
{
    public ParticleSystem rubble;
    public void Destruct()
    {
        Instantiate(rubble, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
