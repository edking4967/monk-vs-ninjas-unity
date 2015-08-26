using UnityEngine;
using Application;
using System.Collections;

public class MovingPlatformLR: Platform {
	Vector2 tempPosition;
	public float deltaX;

	// Use this for initialization
	void Start () {
		deltaX = .002f;
	}
	
	void FixedUpdate () {
		tempPosition = transform.position;

		tempPosition.x += deltaX;

		transform.position = tempPosition;

	}

	/*void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "leftStop" && deltaX <= 0f) {
			// move right:
			deltaX = Mathf.Abs (deltaX);
		}

		if (c.gameObject.tag == "rightStop" && deltaX >= 0f) {	
			// move left:
			deltaX = -1 * Mathf.Abs (deltaX);
			Debug.Log ("hit right stop");
		}

		Debug.Log ("hit stop");

	}*/
	/*
	public  void OnCollisionEnter2D(Collision2D c)
	{
		base.OnCollisionEnter2D (c);

	}
	*/

	public void OnTriggerEnter2D(Collider2D c)
	{
		if (c.gameObject.tag == "leftStop" && deltaX <= 0f) {
			// move right:
			deltaX = Mathf.Abs (deltaX);
		}
		
		if (c.gameObject.tag == "rightStop" && deltaX >= 0f) {	
			// move left:
			deltaX = -1 * Mathf.Abs (deltaX);
			Debug.Log ("hit right stop");
		}
	}

	void OnCollisionStay2D(Collision2D c)
	{

		if (c.gameObject.GetComponent<GravitySprite> ()) {
			tempPosition = c.transform.position;
			
			tempPosition.x += deltaX;
			
			c.transform.position = tempPosition;
		}

	}

}
