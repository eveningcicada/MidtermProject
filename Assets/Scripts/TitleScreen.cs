﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        // if player presses space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //... load the first level.
            SceneManager.LoadScene(1);
        }
	}
}
