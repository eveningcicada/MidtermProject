using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameLogic : MonoBehaviour {

    public GameObject pass;
    public GameObject fail;
    public GameObject CTRL;

    public Image[] BTNs;

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
        foreach(Image BTN in BTNs)
        {
            BTN.transform.localScale = new Vector2(1f, 1f);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            BTNs[0].transform.localScale *= 1.25f;
        }

        if (Input.GetKey(KeyCode.L))
        {
            BTNs[1].transform.localScale *= 1.25f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            BTNs[2].transform.localScale *= 1.25f;
        }

        if (Input.GetKey(KeyCode.I))
        {
            BTNs[3].transform.localScale *= 1.25f;
        }

        if (Input.GetKey(KeyCode.P))
        {
            BTNs[4].transform.localScale *= 1.25f;
        }


        if (victoryPoints <= 0)
        {
            Debug.Log("You Win!");
            pass.SetActive(true);
            CTRL.SetActive(false);

            if(Input.GetKeyDown(KeyCode.Y))
            {
                SceneManager.LoadScene(1);
            }
            else if(Input.GetKeyDown(KeyCode.N))
            {
                SceneManager.LoadScene(0);
            }
        }

        if (bail == true)
        {
            Debug.Log("You Lose!");
            fail.SetActive(true);
            CTRL.SetActive(false);

            if (Input.GetKeyDown(KeyCode.Y))
            {
                SceneManager.LoadScene(1);
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
