using UnityEngine;
using System.Collections;

public class bailLogic : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground"|| other.tag == "Grass")
        {
            Camera.main.GetComponent<gameLogic>().bail = true;
        }
    }
}
