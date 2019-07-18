using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorORNG_script : MonoBehaviour {
    Renderer myRedRender;
    public Color color = new Color(50F, 5F, 0F);


    // Use this for initialization
    void Start () {
        myRedRender = GetComponent<Renderer>();
        myRedRender.material.color = color;


    }

// Update is called once per frame
void Update () {
		
	}
}
