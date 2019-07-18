using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAfterCounter : MonoBehaviour {

 //   public GameObject cube;
 //   public GameObject startCam;
 //   public GameObject go;
    public Animation anim;
    public GameObject introAnim;

    public static bool animEnd;

    private Animator myAnim;
 //   public Camera followCam;
 //   public Camera followCamB;
 //  public bool camNew = false;
   // public static bool change;

    void Start() {
        myAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (introAnim)
        {
            myAnim.enabled = !myAnim.enabled;
        }
        else if(introAnim == null)
        {
           
        }
    }

	// Update is called once per frame
	void fixedUpdate () {

   if (anim.isPlaying)
     {
            animEnd = false;
            anim = GetComponent<Animation>();      

       //     GameObject Cube = Instantiate<GameObject>(cube);

       //     change = true;

       //     GameObject View = Instantiate<GameObject>(Pov);
         
         //   Camera Cam = Instantiate<Camera>(followCam);
          //  Camera CamB = Instantiate<Camera>(followCamB);  

         //   GameObject View = Instantiate<GameObject>(Pov);

            // Physics.gravity = new Vector3(0, -1.0F, 0);

        }

        if (!anim.isPlaying)
        {
     //       Destroy(go);
          animEnd = true;
        }



    } 
}
