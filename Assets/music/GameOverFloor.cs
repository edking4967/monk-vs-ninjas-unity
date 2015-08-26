using UnityEngine;
using System.Collections;

public class GameOverFloor : MonoBehaviour {

	BoxCollider2D collider;

	// Use this for initialization
	void Start () {
		collider = GetComponent<BoxCollider2D> ();
	}
	
	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			UnityEngine.Application.LoadLevel("GameOver");
		}
	}
}
