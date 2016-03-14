using UnityEngine;
using System.Collections;

public class BasicPlayer : MonoBehaviour {

    public int healthPoints = 100;

    AudioSource myAudio;

    public AudioClip explosionSound;

    // Use this for initialization
    
    void Start ()
    {
        myAudio = GetComponent<AudioSource>();
       /*
       if (TitleScreen.useNightmareMode == true)
        {
            healthPoints = 1;
        }
        */
    }
    
	
	// Update is called once per frame
	void Update ()
    {
        /*
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(transform.forward * v * Time.deltaTime * 5f);

        transform.Rotate(transform.up * h * Time.deltaTime * 90f);

        //player death detection
        if( healthPoints <= 0)
        {
            Destroy(gameObject);
        }
        */

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAudio.PlayOneShot(myAudio.clip, 0.5f);
            myAudio.PlayOneShot(explosionSound);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.eulerAngles += new Vector3(0f ,50f * Time.deltaTime, 0f);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            AudioSource.PlayClipAtPoint(explosionSound, Vector3.zero, 1f);
        }
	}
}
