﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiMouseEvents : MonoBehaviour
{
    private Camera cam;
    public Vector3Data data;

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        RaycastHit hit;
        var ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            data.value = hit.point;
        }

    }
}
