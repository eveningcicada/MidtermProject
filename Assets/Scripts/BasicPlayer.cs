using UnityEngine;
using System.Collections;

public class BasicPlayer : MonoBehaviour {

    public int healthPoints = 100;

    // Use this for initialization
    /*
    void Start ()
    {
        if (TitleScreen.useNightmareMode == true)
        {
            healthPoints = 1;
        }
	}
    */
	
	// Update is called once per frame
	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(transform.forward * v * Time.deltaTime * 5f);

        transform.Rotate(transform.up * h * Time.deltaTime * 90f);

        //player death detection
        if( healthPoints <= 0)
        {
            Destroy(gameObject);
        }
	}
}
