using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public float fwardForce;
    public float weaveForce;
    public float leanForce;
    public float pivotForce;
    public float speed;

    public float camHeit;
    public float camDist;

    GameObject mainCam;
    Rigidbody playerRB;

    // Use this for initialization
    void Start ()
    {
        transform.position = new Vector3(-45f, 0.6f, 1f);

        mainCam = GameObject.Find("Main Camera");
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update ()
    {
        //Movement
        
        //Weaving
        if (Input.GetKey(KeyCode.A))
        {
            // Add a FORCE and TILT to the LEFT
            playerRB.AddForce(transform.forward * fwardForce * Time.deltaTime);
            playerRB.AddForce(-transform.right * weaveForce * Time.deltaTime);

            //transform.localEulerAngles += transform.forward * leanForce * Time.deltaTime;
            transform.RotateAround(transform.position - Vector3.up, transform.forward, leanForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.L))
        {
            // Add a FORCE and TILT to the RIGHT
            playerRB.AddForce(transform.forward * fwardForce * Time.deltaTime);
            playerRB.AddForce(transform.right * weaveForce * Time.deltaTime);

            //transform.localEulerAngles -= transform.forward * leanForce * Time.deltaTime;
            transform.RotateAround(transform.position - Vector3.up, transform.forward, -leanForce * Time.deltaTime);
        }

        //Direction
        if (Input.GetKey(KeyCode.W))
        {
            //transform.eulerAngles += new Vector3(0f, -pivotForce * Time.deltaTime, 0f);
            transform.Rotate(0f, -pivotForce * Time.deltaTime, 0f, Space.World);
            //transform.RotateAround(transform.position, Vector3.up, -pivotForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.I))
        {
            //transform.eulerAngles += new Vector3(0f, pivotForce * Time.deltaTime, 0f);
            transform.Rotate(0f, pivotForce * Time.deltaTime, 0f, Space.World);
            //transform.RotateAround(transform.position, Vector3.up, pivotForce * Time.deltaTime);
        }

        //Stopping
        if (Input.GetKey(KeyCode.P))
        {
            playerRB.drag = 2f;
        }
        else
        {
            playerRB.drag = 0f;
        }

        //Bailing
        if (transform.localEulerAngles.z > 5 && transform.localEulerAngles.z < 355)
        {
            playerRB.constraints = RigidbodyConstraints.None;
            playerRB.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        }
        else
        {
            playerRB.constraints = RigidbodyConstraints.FreezeRotation;
        }

        //Camera Positioning
        mainCam.transform.localPosition = new Vector3(0f, camHeit, -camDist);
    }
}
