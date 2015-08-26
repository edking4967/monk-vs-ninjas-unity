using UnityEngine;
using System.Collections;

public class StopCamera : MonoBehaviour {

	BoxCollider2D collider;
	CSharpSmoothFollow2D cameraScript;

	// Use this for initialization
	void Start () {
		collider = GetComponent<BoxCollider2D> ();
		cameraScript = GameObject.Find ("Main Camera").GetComponent<CSharpSmoothFollow2D> ();
	}
	
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			cameraScript.allowedToMove = false;
		}
	}

}
