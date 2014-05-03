using UnityEngine;
using System.Collections;

public class BouncyGround : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionExit(Collision info){
		animation.Play ("Bouncy");
	}
}
