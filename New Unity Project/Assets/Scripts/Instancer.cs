using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public ApplyForce prefab;

    // Update is called once per frame
     public void CreateInstance()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
