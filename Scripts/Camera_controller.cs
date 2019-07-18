using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour
{

    public GameObject player;
    private Rigidbody rb;
    public int tempZoom = 0;
    private Vector3 offSet;
    // private Vector3 offset;

    // public float turnSpeed = 0.40f;
    // public Transform gc;

    void Start()
    {
        //     rb = GetComponent<Rigidbody>();
        //      offset = new Vector3(gc.position.x, gc.position.y + 8.0f, gc.position.z + 0.0f);

    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (tempZoom == 20)
            {
                Debug.Log("You've hit the limit!");
                //if it's 20 they zoom out any higher
            }
            else
            {
                transform.Translate(0.0f, 0.0f, -3.0f);
                tempZoom += 5;
                //Zooms out and variable increments until it hits 20
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (tempZoom == 0)
            {
                Debug.Log("You can't zoom in anymore!");
                //tell user they can't zoom in
            }
            else
            {
                transform.Translate(0.0f, 0.0f, 3.0f);
                tempZoom -= 5;
                //Zooms in and variable  decreases
            }
        }
    }


        /*   void LateUpdate()
           {
               offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
               transform.position = gc.position + offset;
               transform.LookAt(gc.position);
           }
           */
    }
