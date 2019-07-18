using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_script2 : MonoBehaviour {

    Renderer myRedRender;
    public static bool color;

    void Start () {
        myRedRender = GetComponent<Renderer>();
        myRedRender.material.color = Color.red;
    }
	
	// Update is called once per frame
	void Update () {
        colorPass();
    }

    void colorPass()
    {
        if (color == true)
        {
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.green;

        }
    }
}
