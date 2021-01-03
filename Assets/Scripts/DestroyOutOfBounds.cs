﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 40;
    public float lowerBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= topBound)
            Destroy(gameObject);
        else if(transform.position.z < lowerBound)
        {
            Debug.Log("Game over");
            Destroy(gameObject);
        }
    }
}
