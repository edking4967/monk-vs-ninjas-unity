using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	Rigidbody2D rb;
	Vector2 forwardVector;
	Vector2 backVector;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		moveSpeed = transform.localScale.x * .25f;

		forwardVector = new Vector2 (moveSpeed, 0);
		backVector = new Vector2 (-moveSpeed, 0);

		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = forwardVector;
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "rightStop") {
			rb.velocity = backVector;
		}
		else if (c.tag == "leftStop") {
			rb.velocity = forwardVector;
		}

	}
}
