using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public float fwardForce;
    public float weaveForce;
    public float pivotForce;
    public float speed;

    public float camHeit;
    public float camDist;

    GameObject mainCam;
    Rigidbody playerRB;

    // Use this for initialization
    void Start ()
    {
        mainCam = GameObject.Find("Main Camera");

        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        //Movement
        /*
            Weaving and Strafing
        */
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerRB.velocity = new Vector3(0f, 0f, playerRB.velocity.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Add a FORCE and TILT to the LEFT
            playerRB.AddForce(transform.forward * fwardForce * Time.deltaTime);
            playerRB.AddForce(-transform.right * weaveForce * Time.deltaTime);

            // Map this to controller LEFT TRIGGER
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            playerRB.velocity = new Vector3(0f, 0f, playerRB.velocity.z);
        }

        if (Input.GetKey(KeyCode.L))
        {
            // Add a FORCE and TILT to the RIGHT
            playerRB.AddForce(transform.forward * fwardForce * Time.deltaTime);
            playerRB.AddForce(transform.right * weaveForce * Time.deltaTime);

            // Map this to controller RIGHT TRIGGER
        }

        /*
            Direction
        */
        if (Input.GetKey(KeyCode.W))
        {
            transform.localEulerAngles += new Vector3(0f, -pivotForce * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.I))
        {
            transform.localEulerAngles += new Vector3(0f, pivotForce * Time.deltaTime, 0f);
        }

        //Camera Positioning
        mainCam.transform.position = transform.position + new Vector3(0f, camHeit, -camDist);
    }
}
