using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
	float rotationSpeed = 100;

	// Use this for initialization
	void Start () {
		// called when the game starts
	}
	
	// Update is called once per frame
	void Update () {
		// called every time a frame is rendered

		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		// make sure the ball rotates at the same speed independent of framerate
		rotation *= Time.deltaTime;

		//make the object rotate
		// Vector3 (3d coords) in direction "back"
		rigidbody.AddRelativeTorque (Vector3.back * rotation);

	}
}
