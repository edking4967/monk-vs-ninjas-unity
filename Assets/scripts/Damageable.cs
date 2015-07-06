using UnityEngine;
using System.Collections;


public class Damageable : MonoBehaviour {

	float timeSave;
	Timer timer;
	GameObject damageBG;

	void Start()
	{
		timer = new Timer (.5f);
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "Projectile") {
			doDamage ();

			Destroy(c.gameObject);
		}
	}

	void Update()
	{

		if (timer.check ()) {
			clearDamage();
		}
	}

	void doDamage()
	{
		GetComponent<SpriteRenderer> ().color = Color.red;
		damageBG = (GameObject)Instantiate(Resources.Load("prefabs/damageBG")); 
		Vector2 newPos = this.transform.position;
		damageBG.transform.position = newPos;
		timer.set ();
	}

	void clearDamage()
	{
		GetComponent<SpriteRenderer> ().color = Color.white;
		Destroy (damageBG);
	}
}
