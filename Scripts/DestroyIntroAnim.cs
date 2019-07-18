using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIntroAnim : MonoBehaviour {

    public Animation anim;
    public Animation anim2;
    public static bool animEnd;
    
    public GameObject CD;

    // Use this for initialization
    void Start () {
        animEnd = false;
        CD.SetActive(animEnd);
    }
	
	// Update is called once the animation event is triggered at the end of the Animation
	void fixedUpdate () {

        //     anim2.Play();
        animEnd = true;
        CD.SetActive(animEnd);
        Destroy(gameObject);

    
    }

   
}
