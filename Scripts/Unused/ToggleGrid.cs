using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGrid : MonoBehaviour {

    private Rigidbody rb;
    private Renderer rend;
    private bool mybool;

    void Start () {

        rend = GetComponent<Renderer>();
        rend.enabled = true;

    }

    // Update is called once per frame
    void Update() {

        toggler();

    }

    void toggler()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            mybool = !mybool;
        }

        if (mybool == false)
        {
            rend.enabled = true;
        }

        else if (mybool == true)
        {
            rend.enabled = false;
        }
    }
    
}
