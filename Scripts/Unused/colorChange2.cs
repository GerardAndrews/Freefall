﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GameCube")
        {
            color_script2.color = true;

        }

    }

    void OnTriggerStay(Collider other)
    {
        color_script2.color = true;

    }

    void OnTriggerExit(Collider other)
    {
        color_script2.color = true;

        //  pass.Play();
    }
}
