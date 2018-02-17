using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("Player Rotate ready!");
	}
	
	// Update is called once per frame
	void Update () {

		float rotationSpeed = 4.0f;

		// Adjust camera X
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		transform.localRotation *= Quaternion.Euler (0, mouseX, 0);

		// Adjust camera Y
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		GetComponentInChildren<Camera>().transform.localRotation *= Quaternion.Euler (-mouseY, 0, 0);
	
	}
}
