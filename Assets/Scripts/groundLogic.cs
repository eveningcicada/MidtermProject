using UnityEngine;
using System.Collections;

public class groundLogic : MonoBehaviour {

    bool collided = false;

	void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player" && collided == false)
        {
            Camera.main.GetComponent<gameLogic>().victoryPoints--;
            collided = true;
        }
    }
}
