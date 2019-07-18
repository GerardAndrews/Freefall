using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POV_controller : MonoBehaviour {

   

    public Transform Player;
    public Camera FirstPersonCam, ThirdPersonCam;
    public Camera GO;
    public KeyCode TKey;
    public bool camSwitch = true;

    void Update()
    {
        if (Input.GetKeyDown(TKey))
        {
            camSwitch = !camSwitch;
            FirstPersonCam.gameObject.SetActive(camSwitch);
            ThirdPersonCam.gameObject.SetActive(!camSwitch);
         
        }

      /*  if (FirstPersonCam = null)
        {
            GO.gameObject.SetActive(camSwitch);
        }

       else if(ThirdPersonCam = null)
        {
            GO.gameObject.SetActive(camSwitch);
        }
        */
    }
}
