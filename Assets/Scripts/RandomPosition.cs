﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour {
    public Vector3[] positions;
   
    public int randomNumber;
    // Use this for initialization


    /**
     * test code to check the random position
     */

    void Start () {
        randomNumber = Random.Range(0, positions.Length);
        transform.position = positions[randomNumber];
    }
	
	
}
