using UnityEngine;
using System.Collections;
using Application;

public class MonkController : MonoBehaviour {
	public bool isJumping = true;	
	public bool isFacingRight = true;
	public GameObject monk;
	Animator anim;
	Rigidbody2D rb;
	public int health = 10;
	GameObject proj;
	Vector2 projVel;

	public void Start()
	{
		monk = GameObject.Find ("Monk");
		anim = monk.GetComponent<Animator> ();
		rb = monk.GetComponent<Rigidbody2D> ();
	}

	public void Update()
	{
		checkOffscreen ();

	}
		
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "enemyProjectile") {
			this.health--;
			Destroy (c.gameObject);
		}
	}

	public void fireProjectile()
	{
		proj = (GameObject)Instantiate(Resources.Load("Prefabs/projectile")); 
		proj.transform.position = monk.transform.position;
		projVel = new Vector2 (.1f,0);

		if (!GetComponent<MonkController> ().isFacingRight)
			projVel = -projVel;

		proj.GetComponent<Rigidbody2D> ().AddForce (projVel);
	}

	public void checkOffscreen()
	{
		if (!monk.GetComponent<Renderer> ().isVisible ) {
			Debug.Log ("monk offcreen");
		}
	}
}
