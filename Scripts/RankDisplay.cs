using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankDisplay : MonoBehaviour
{

    Renderer myRedRender;

    public GUIText rankDisplay;
    public GUIText returnDisplay;

    private bool returns;

    // Use this for initialization
    void Start()
    {
        returns = false;

        returnDisplay.text = "";
        rankDisplay.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (returns)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                    startAfterCounter.animEnd = false;

                SceneManager.LoadScene(0);  //this works, not application
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
       
       

        if (RankValue.rank == 4 && other.gameObject.name == "GameCube")
        {
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.red;
            rankDisplay.text = "Rank: A";

            returns = true;
            returnDisplay.text = "Press R to return to Selection";
        }
        if (RankValue.rank == 3 && other.gameObject.name == "GameCube")
        {
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.green;
            rankDisplay.text = "Rank: B";

            returns = true;
            returnDisplay.text = "Press R to return to Selection";
        }
        if (RankValue.rank == 2 && other.gameObject.name == "GameCube")
        {
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.blue;
            rankDisplay.text = "Rank: C";

            returns = true;
            returnDisplay.text = "Press R to return to Selection";
        }
        if (RankValue.rank == 1 && other.gameObject.name == "GameCube")
        {
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.yellow;
            rankDisplay.text = "Rank: D";

            returns = true;
            returnDisplay.text = "Press R to return to Selection";
        }
        if (RankValue.rank == 0 && other.gameObject.name == "GameCube")
        {
            myRedRender = GetComponent<Renderer>();
            myRedRender.material.color = Color.magenta;
            rankDisplay.text = "Rank: F";

           returns = true;
            returnDisplay.text = "Press R to return to Selection";

        }

       

    }
}