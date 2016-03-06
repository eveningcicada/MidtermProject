using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour {

    public int healthPoints; // Deathzone will subtract health from player
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            // relaods the current scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
