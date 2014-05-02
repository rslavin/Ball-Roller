using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// public variables are accessible in Unity
	public int rotationSpeed = 100;
	public int jumpHeight = 8;
	public bool doubleJump = true;

	private bool isFalling = false;

	// Use this for initialization
	void Start () {
		// called when the game starts
	}
	
	// Update is called once per frame
	void Update () {

		/* BEGIN BALL ROTATION */
		// take horizontal input from controller
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;

		// make sure the ball rotates at the same speed independent of framerate
		// increase rotation based on time. This way, if the frames lag, the 
		// movement is increased based on time (which doesn't lag).
		rotation *= Time.deltaTime;

		//make the object rotate
		// Vector3 (3d coords) in direction "back"
		// back * rotation => direction * input
		rigidbody.AddRelativeTorque (Vector3.back * rotation);

		/* END BALL ROTATION */

		/* BEGIN BALL JUMP */
		if ((Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.Space)) && !isFalling) {
			if(doubleJump)
				isFalling = true;
			Vector3 currentV = rigidbody.velocity;
			currentV.y = jumpHeight;
			rigidbody.velocity = currentV;
		}
		if (!doubleJump)
			isFalling = true;
		/* END BALL JUMP */

	}

	// this function is provided by Unity
	// is called when a collision happens.
	void OnCollisionStay(){
		isFalling = false;
	}
}
