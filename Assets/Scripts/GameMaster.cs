using UnityEngine;
using System.Collections;

// keep track of global variables
public class GameMaster : MonoBehaviour {
	// static so we can access it from all scripts
	public static int currentScore = 0;
	public float offsetY = 40;
	public float sizeX = 100;
	public float sizeY = 40;

	/*
	// use this as a temporary var so we can view the 
	// score in unity as a public variable
	public int test = 0;

	void Update(){
		test = currentScore;
	}
	*/

	void OnGUI(){
		GUI.Box (new Rect ((Screen.width / 2) - (sizeX /2), Screen.height/20, sizeX, sizeY), "Score\n"+currentScore);
	}
}
