using UnityEngine;
using System.Collections;

public class BladeController : MonoBehaviour {

    public float speed;
    public float lean;
    public WheelCollider front;
    public WheelCollider rear;

    GameObject LeftBlade;
    GameObject RightBlade;
    Rigidbody bladeRB;

	// Use this for initialization
	void Start ()
    {
        bladeRB = GetComponent<Rigidbody>();

        LeftBlade = GameObject.Find("LeftBlade");
        RightBlade = GameObject.Find("RightBlade");
	}
	
	// Update is called once per frame
	void Update ()
    {
        // MOVEMENT
        /*
        if (Input.GetKey(KeyCode.W))
        {
            // Add a forward FORCE
            bladeRB.AddForce(transform.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Add a backward FORCE
            bladeRB.AddForce(transform.forward * -speed * Time.deltaTime);
        }

        // LEANING
        if (Input.GetKey(KeyCode.A))
        {
            transform.localEulerAngles += new Vector3(0f, 0f , lean * Time.deltaTime);
            //front.steerAngle -= lean * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localEulerAngles += new Vector3(0f, 0f, -lean * Time.deltaTime);
            //front.steerAngle += lean * Time.deltaTime;
        }
        */
        if (Vector3.Distance(LeftBlade.transform.position, RightBlade.transform.position) > 4f)
        {
            bladeRB.velocity = Vector3.zero;
        }

        if (this.gameObject.name == "LeftBlade")
        {
            if (Input.GetKey(KeyCode.A))
            {
                //add a FORWARD force
                bladeRB.AddForce(transform.forward * speed * Time.deltaTime);

                RightBlade.transform.position = new Vector3(LeftBlade.transform.position.x + 3f, RightBlade.transform.position.y, LeftBlade.transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                RightBlade.transform.localPosition += Vector3.up;
                RightBlade.GetComponent<Rigidbody>().velocity = Vector3.zero;
                RightBlade.GetComponent<Rigidbody>().useGravity = false;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                RightBlade.transform.localPosition -= Vector3.up;
                RightBlade.GetComponent<Rigidbody>().useGravity = true;
            }
        }

        if (this.gameObject.name == "RightBlade")
        {
            if (Input.GetKey(KeyCode.L))
            {
                //add a FORWARD force
                bladeRB.AddForce(transform.forward * speed * Time.deltaTime);

                LeftBlade.transform.position = new Vector3(RightBlade.transform.position.x - 3f, LeftBlade.transform.position.y, RightBlade.transform.position.z);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                LeftBlade.transform.localPosition += Vector3.up;
                LeftBlade.GetComponent<Rigidbody>().velocity = Vector3.zero;
                LeftBlade.GetComponent<Rigidbody>().useGravity = false;
            }
            if (Input.GetKeyUp(KeyCode.L))
            {
                LeftBlade.transform.localPosition -= Vector3.up;
                LeftBlade.GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}
