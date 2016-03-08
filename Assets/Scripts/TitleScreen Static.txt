using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

    //"static" means this variable lives in the code, not on a game object
    //this variable will "persist" beyond a scene change

    public static bool useNightmareMode = false;

	// Update is called once per frame
	void Update ()
    {
        // if player presses space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //... load the first level.
            SceneManager.LoadScene(1);
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            useNightmareMode = !useNightmareMode;

            Debug.Log("Nightmare Mode: " + useNightmareMode);
        }
	}
}
