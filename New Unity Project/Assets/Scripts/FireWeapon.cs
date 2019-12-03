using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public ApplyForce ammo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Fire1"))
        {
            Instantiate(ammo, transform.position, Quaternion.identity);
        }
    }
}
