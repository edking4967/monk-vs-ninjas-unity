using UnityEngine;
using System.Collections;

public class Dragon : MonoBehaviour {

	Rigidbody2D rb;
	bool isMoving;
	bool isFacingRight = false;
	Timer fireTimer;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//rb.mass = 1;
	
		isMoving = true;

		fireTimer = new Timer (1);

		fireTimer.set ();
		
	}

	public void fireProjectile()
	{
		Debug.Log ("fireProjectile");	
		GameObject proj = (GameObject)Instantiate(Resources.Load("Prefabs/projectile")); 
		proj.transform.position = new Vector2(transform.position.x-.5f, transform.position.y-.5f);
		Vector2 vel = new Vector2 (.1f,0);
		
		if (!isFacingRight)
			vel = -vel;
		
		proj.GetComponent<Rigidbody2D> ().AddForce (vel);

	}

	
	// Update is called once per frame
	void FixedUpdate () {

		if (isMoving)
			rb.velocity = new Vector2 (0, 1);
		else
			rb.AddForce (new Vector2 (0, 9.81f));

		if (fireTimer.check ()) {
			fireProjectile();
			fireTimer.set();
		}
			
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.tag == "DragonStop")
			isMoving = false;
	}
}
