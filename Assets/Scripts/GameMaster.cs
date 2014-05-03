using UnityEngine;
using System.Collections;

// keep track of global variables
public class GameMaster : MonoBehaviour {
	// static so we can access it from all scripts
	public static int currentScore = 0;
	public float offsetY = 40;
	public float sizeX = 100;
	public float sizeY = 40;
	public static bool playMusic;

	void Start(){
		// reset everything
		currentScore = 0;
		playMusic = true;
		BallControl.isFalling = true;
	}

	/*
	// use this as a temporary var so we can view the 
	// score in unity as a public variable
	public int test = 0;

	void Update(){
		test = currentScore;
	}
	*/

	void Update(){
		// check if another object wants music to stop
		if(!playMusic){
			audio.Stop();
		}
	}

	void OnGUI(){
		GUI.Box (new Rect ((Screen.width / 2) - (sizeX /2), Screen.height/20, sizeX, sizeY), "Score\n"+currentScore);
	}
}
