using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {
	public int maxFallDistance = -10;
	private bool isRestarting = false;

	public AudioClip gameOverSound;

	// Update is called once per frame
	void Update () {
		if (transform.position.y <= maxFallDistance) {
			// helps with debugging
			// Debug.Log ("DEAD!");

			// make sure to add the level to File>Build Settings
			// in order for the String to properly reference it
			// when multiple scenes exist
			if(!isRestarting){
				StartCoroutine(RestartLevel());
			}
		}
	}

	// has to be IEnumerator because of the yield
	IEnumerator RestartLevel(){
		//Debug.Log ("DEAD");
		isRestarting = true;
		// reset the current audioclip to our public var GameOverSound;
		audio.clip = gameOverSound;
		audio.pitch = 1;
		// stop background music
		GameMaster.playMusic = false;
		audio.Play ();// empty means it will play the first audio attached
		yield return new WaitForSeconds (audio.clip.length);
		Application.LoadLevel ("MainLevel");
		isRestarting = false;
	}
}
