using UnityEngine;
using System.Collections;

public class MonkController : MonoBehaviour {
	public bool isJumping = true;	
	public bool isFacingRight = true;
	public GameObject monk;
	Animator anim;
	Rigidbody2D rb;
	private float runVel = 1.41f;

	public void Start()
	{
		monk = GameObject.Find ("Monk");
		anim = monk.GetComponent<Animator> ();
		rb = monk.GetComponent<Rigidbody2D> ();
	}

	public void Update()
	{
		checkOffscreen ();

		anim.SetFloat ("Speed", Mathf.Abs( rb.velocity.x));
	}
	
	public void jump()
	{
		if (isJumping) {
			return;
		}

		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("jumping")) {
			return;
		}
			
		Debug.Log ("jumping!");
		monk.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,200));
		isJumping = true;
		anim.SetTrigger("Jump");

		anim.SetBool ("Land", false);
	}

	public void land()
	{
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("idle"))
			return;
		isJumping = false;
		anim.SetTrigger ("Land");
		anim.SetBool ("Jump", false);
	}
		
	public void run(Vector2 dir)
	{
		Vector2 vel = rb.velocity;
		vel.x = dir.x * runVel;
		rb.velocity = vel;
	}

	public void fireProjectile()
	{
		Debug.Log ("fireProjectile");	
		GameObject proj = (GameObject)Instantiate(Resources.Load("projectile")); 
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
