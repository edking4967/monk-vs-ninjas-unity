using UnityEngine;
using System.Collections;
using AssemblyCSharp;
using Application;

public class Dragon : MonoBehaviour {

	Rigidbody2D rb;
	bool isMoving;
	bool isFacingRight = false;
	Timer fireTimer;
	AIState currentState;
	GameObject monk;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//rb.mass = 1;
	
		isMoving = true;

		fireTimer = new Timer (1);

		fireTimer.set ();

		currentState = new DragonInitialState ();
		currentState.doStart (this.gameObject);

		monk = GameObject.Find ("Monk");
		
	}

	public void fireProjectile()
	{
		Debug.Log ("fireProjectile");	
		GameObject proj = (GameObject)Instantiate(Resources.Load("Prefabs/projectile")); 
		proj.tag = "enemyProjectile";
		proj.transform.position = new Vector2(transform.position.x-.5f, transform.position.y-.5f);
		float velMag = .1f;

		Vector2 velDir = monk.transform.position - proj.transform.position;
		velDir = velDir / velDir.magnitude;

		proj.GetComponent<Rigidbody2D> ().AddForce (velDir * velMag);

	}

	
	// Update is called once per frame
	void FixedUpdate () {

		currentState.doFixedUpdate ();
			
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "DragonStop") {
			currentState = new DragonFireState ();
			currentState.doStart(this.gameObject);
		}

	}
}
