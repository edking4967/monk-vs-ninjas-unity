using UnityEngine;
using System.Collections;

public class Dragon : MonoBehaviour {

	Rigidbody2D rb;
	bool isMoving;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//rb.mass = 1;
	
		isMoving = true;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (!isMoving)
			rb.AddForce (new Vector2 (0, 9.81f));
		else
			rb.velocity = new Vector2 (0, 1);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		isMoving = false;
	}
}
