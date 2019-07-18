using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotTimer : MonoBehaviour {

    public GameObject Shot;
    public Transform ShotSpawn;

    public float myTime = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        myTime += Time.deltaTime;

        if (myTime > 2.0f)
        {
            myTime -= 2.0f;
            Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
        }

	}
}
