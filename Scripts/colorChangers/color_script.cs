using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_script : MonoBehaviour {

    Renderer myRedRender;
   // public static int rank = 0;
  //public AudioSource pass;
  


    void Start () {
    //    pass = GetComponent<AudioSource>();
        myRedRender = GetComponent<Renderer>();
        myRedRender.material.color = Color.red;

        
    }

    // Update is called once per frame
    void Update() {
    
                  }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "GameCube")
        {
            // On collison between GC and the Pathway opening, Pathway color changes green
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.green;

            RankValue.rank += 1;
            

        }

    }

  



}
