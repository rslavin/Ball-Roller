using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public Transform target; // Transform is used for instantiation
	public int distance = -10; // distance from the target (negative direction on axis)
	public double lift = 1.5; // move up the y axis to tilt

	// Update is called once per frame
	void Update () {
		// move camera with ball
		transform.position = target.position + new Vector3 (0, (float)lift, (float)distance);
		transform.LookAt (target);
	}
}
