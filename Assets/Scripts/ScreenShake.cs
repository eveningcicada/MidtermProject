using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

    public float shake = 0f;
    public float shakeAmount = 0.7f;
    public float decreaseFactor = 1.0f;

    private Transform camTransform;
    private Vector3 originalPos;

	// Use this for initialization
	void Start ()
    {
        camTransform = this.transform;
        originalPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Camera shake
        if (shake > 0)
        {
            camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;

            shake -= Time.deltaTime * decreaseFactor;
        }
        else
        {
            shake = 0f;
            camTransform.localPosition = originalPos;
        }
    }
}
