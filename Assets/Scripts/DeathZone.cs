using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter (Collider activator)
    {
        //trigger will read when player passes the finish line

        //Destroy(activator.gameObject);

    }

    void OnTriggerStay (Collider activator)
    {
        activator.GetComponent<BasicPlayer>().healthPoints -= 2;
    }

    void OnTriggerExit (Collider activator)
    {

    }
}
