using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
 //   public GameObject explosion;
    public GameObject playerExplosion;
  //  public int scoreValue;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
           if (other.tag == "Boundary")//calls to Boundary Tag
           {
               return; 
           }
           
        // Instantiate(playerExplosion, transform.position, transform.rotation);
        
        if (other.tag == "stop")
        {
            //Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            Instantiate(playerExplosion, transform.position, transform.rotation);
            Destroy(gameObject);//Destroys object
            gameController.GameOver();
            //  gameController.GameOver();
        }
        
       // gameController.AddScore(scoreValue);
     //   Destroy(other.gameObject);//Destroys laser bolt
       
    }
}