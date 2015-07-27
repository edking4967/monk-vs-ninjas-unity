using UnityEngine;
using System.Collections;
using Application;

public class MonkController : MonoBehaviour {
	public bool isJumping = true;	
	public bool isFacingRight = true;
	public GameObject monk;
	Animator anim;
	Rigidbody2D rb;

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
		


	public void fireProjectile()
	{
		Debug.Log ("fireProjectile");	
		GameObject proj = (GameObject)Instantiate(Resources.Load("Prefabs/projectile")); 
		proj.transform.position = monk.transform.position;
		Vector2 vel = new Vector2 (.1f,0);

		if (!GetComponent<MonkController> ().isFacingRight)
			vel = -vel;

		proj.GetComponent<Rigidbody2D> ().AddForce (vel);
	}

	public void checkOffscreen()
	{
		if (!monk.GetComponent<Renderer> ().isVisible ) {
			Debug.Log ("monk offcreen");
		}
	}
}
