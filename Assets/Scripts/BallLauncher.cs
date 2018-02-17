using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;

	// Use this for initialization
	void Start () {
		print("Ball Spawner ready!");
	}
	
	// Update is called once per frame
	void Update () {

		// Shoot the ball with right mouse button
		if (Input.GetButtonDown ("Fire1")) {
			GameObject newBall = Instantiate (ballPrefab);
			// Give velocity to the ball
			newBall.transform.position = transform.position; // spawn at the camera player
			Rigidbody rb = newBall.GetComponent<Rigidbody> ();
			rb.velocity = Vector3.forward * ballSpeed;
		}


//		if (Input.GetKeyDown (KeyCode.UpArrow)) {
//			
//		} else if (Input.GetKeyDown (KeyCode.LeftArrow)) {
//			GameObject newBall = Instantiate (ballPrefab);
//			// Give velocity to the ball
//			Rigidbody rb = newBall.GetComponent<Rigidbody> ();
//			rb.velocity = Vector3.left * speed;
//		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
//			GameObject newBall = Instantiate (ballPrefab);
//			// Give velocity to the ball
//			Rigidbody rb = newBall.GetComponent<Rigidbody> ();
//			rb.velocity = Vector3.right * speed;
//		}
	}
}
