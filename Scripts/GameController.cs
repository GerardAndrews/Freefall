using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GUIText restartText;
    public GUIText gameOverText;

    private bool gameOver;
    private bool restart;

    void Start ()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
    }
	
	
	void Update ()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                startAfterCounter.animEnd = false;
            
                SceneManager.LoadScene("level-1");  //this works, not application
            }
        }

      if (gameOver) //
        {
            restartText.text = "Press 'R' for Restart";
            restart = true; 
        }
      
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
