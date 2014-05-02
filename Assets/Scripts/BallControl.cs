using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// public variables are accessible in Unity
	public int rotationSpeed = 100;
	public int jumpHeight = 8;
	public bool doubleJump = true;
	public AudioClip hit1, hit2, hit3;

	private bool isFalling = false;
	private bool playOnce = true;


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
			StartCoroutine(playOnceTrue ());
		}
		if (!doubleJump)
			isFalling = true;
		/* END BALL JUMP */

	}

	void OnCollisionExit(){
			playOnce = true;
	}

	// this function is provided by Unity
	// is called when a collision happens.
	void OnCollisionStay(){

		if (playOnce) {
			int theHit = Random.Range (0, 2);
			audio.pitch = Random.Range ((float)0.9, (float)1.1);
			switch (theHit){
				case 0:					
					audio.clip = hit1;
					break;
				case 1:
					audio.clip = hit2;
					break;
				case 2:
					audio.clip = hit3;
					break;
				default:
					Debug.Log("default case!");
					break;
			}
			audio.Play();
			playOnce = false;
		}
		isFalling = false;
	}

	// added a pause otherwise the switch doesn't occur
	IEnumerator playOnceTrue(){
		yield return new WaitForSeconds ((float)0.1);
		playOnce = true;
	}
}
