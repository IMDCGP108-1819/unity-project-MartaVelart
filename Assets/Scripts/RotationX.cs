﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationX : MonoBehaviour
{

    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed, 0, 0);
    }
}
