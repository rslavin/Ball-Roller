using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {
	public Transform coinEffect;

	// Called when something enters it
	void OnTriggerEnter (Collider info) {
		// info will be the thing that enters the coin
	
		// make sure to tag the ball as player
		if (info.tag.Equals ("Player")) {
			//Debug.Log ("coin picked up");

			// create the coin effect particles
			Transform effect = (Transform) Instantiate(coinEffect, transform.position, transform.rotation);

			// second param is a timer in seconds
			Destroy (effect.gameObject, 3);
			// gameObject is the object the script is attached to
			Destroy (gameObject);

		}
	}
}
