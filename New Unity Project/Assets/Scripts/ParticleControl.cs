using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleControl : MonoBehaviour
{
    public ParticleSystem explosion;
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        explosion.Emit(100);
    }
}

