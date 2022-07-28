using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Devil : MonoBehaviour
{
    public Transform Spear;
    public double a = 0;

    private void Update()
    {




    }
    private void OnMouseDown()
    {
        if (a <= 12)
        {
            a += Time.deltaTime;

            float b = (float)Math.Sin(a) / 3;
            Spear.Translate(Vector3.up * 0.004f * b);
        }
    }
}