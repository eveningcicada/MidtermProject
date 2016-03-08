using UnityEngine;
using System.Collections;

public class gameLogic : MonoBehaviour {

    public bool bail = false;
    public int victoryPoints = 0;

    GameObject[] grounds;

	// Use this for initialization
	void Start ()
    {
        grounds = GameObject.FindGameObjectsWithTag("Ground");

        victoryPoints = grounds.Length;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (victoryPoints <= 0)
        {
            Debug.Log("You Win!");
        }

        if (bail == true)
        {
            Debug.Log("You Lose!");
        }
	}
}
