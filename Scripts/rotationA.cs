﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationA : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.right, speed);
    }
}
