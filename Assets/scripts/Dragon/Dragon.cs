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
	GameObject proj;
	Vector2 velDir;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	
		isMoving = true;

		fireTimer = new Timer (1);

		fireTimer.set ();

		currentState = new DragonInitialState ();
		currentState.doStart (this.gameObject);

		monk = GameObject.Find ("Monk");
		
	}

	public void fireProjectile()
	{
		proj = (GameObject)Instantiate(Resources.Load("Prefabs/projectile")); 
		proj.tag = "enemyProjectile";
		proj.transform.position = new Vector2(transform.position.x-.5f, transform.position.y-.5f);
		float velMag = .05f;

		velDir = monk.transform.position - proj.transform.position;
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
