using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	// public variables are accessible in Unity
	public int rotationSpeed = 100;
	public int jumpHeight = 8;
	public int jumpBounceHeight = 13;
	public bool doubleJump = false;
	public AudioClip hit1, hit2, hit3, boing, thump;

	public static bool isFalling = false;
	public static bool bouncy = false;


	// Use this for initialization
	void Start () {
		// called when the game starts
	}
	
	// Update is called once per frame
	void Update () {
		if (bouncy) {
				}
			//Debug.Log ("bouncy");

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
			isFalling = true;
			Vector3 currentV = rigidbody.velocity;
			if(bouncy)
				currentV.y = jumpBounceHeight;
			else
				currentV.y = jumpHeight;
			rigidbody.velocity = currentV;
			if(bouncy){
				audio.clip = boing;
				audio.Play ();
			}
		}

		/* END BALL JUMP */

	}

	void OnCollisionExit(Collision info){
		isFalling = true;
		if (info.collider.tag.Equals ("Bouncy")) {
			bouncy = false;
		}
	}

	void OnCollisionStay(){
				isFalling = false;
		}

	// this function is provided by Unity
	// is called when a collision happens.
	void OnCollisionEnter(Collision info){
		isFalling = false;
		audio.pitch = Random.Range ((float)0.9, (float)1.1);
		if (!info.collider.tag.Equals("Bouncy")) {
				int theHit = Random.Range (0, 2);				
				switch (theHit) {
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
						Debug.Log ("default case!");
						break;
				}
		} else {
			Debug.Log ("collision enter bouncy");
			bouncy = true;
			audio.clip = thump;
		}
		audio.Play();		

	}


}
