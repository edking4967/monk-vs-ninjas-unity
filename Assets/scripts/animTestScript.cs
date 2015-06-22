using UnityEngine;
using System.Collections;

public class animTestScript : MonoBehaviour {

	public bool changeState=false;
	Animator playerAnim;
	// Use this for initialization
	void Start () {
		playerAnim = GameObject.Find ("player").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (changeState)
			playerAnim.SetTrigger ("Run");
	}
}
