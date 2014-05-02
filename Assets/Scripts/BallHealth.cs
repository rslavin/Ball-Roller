using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public int maxFallDistance = -10;

	// Update is called once per frame
	void Update () {
		if (transform.position.y <= maxFallDistance) {
			// helps with debugging
			// Debug.Log ("DEAD!");

			// make sure to add the level to File>Build Settings
			// in order for the String to properly reference it
			// when multiple scenes exist
			Application.LoadLevel ("MainLevel");
		}
	}
}
