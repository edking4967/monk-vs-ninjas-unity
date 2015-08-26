using UnityEngine;
using System.Collections;

public class bgVillager : MonoBehaviour {

	Rigidbody2D rb;
	Vector3 scale;
	Vector3 flippedScale;
	Vector2 forwardVector;
	Vector2 backVector;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
		moveSpeed = transform.localScale.x * .35f / .25f;

		forwardVector = new Vector2 (moveSpeed, 0);
		backVector = new Vector2 (-moveSpeed, 0);

		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = forwardVector;
		scale = transform.localScale;
		flippedScale = scale;
		flippedScale.x = -flippedScale.x;
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "rightStop") {
			rb.velocity = backVector;
			transform.localScale = flippedScale;
		}
		else if (c.tag == "leftStop") {
			rb.velocity = forwardVector;
			transform.localScale = scale;
		}

	}
}
