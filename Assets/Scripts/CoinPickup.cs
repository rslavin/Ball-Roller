using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	// Called when something enters it
	void OnTriggerEnter (Collider info) {
		// info will be the thing that enters the coin
	
		// make sure to tag the ball as player
		if (info.tag.Equals ("Player")) {
			//Debug.Log ("coin picked up");

			// gameObject is the object the script is attached to
			Destroy (gameObject);
		}
	}
}
