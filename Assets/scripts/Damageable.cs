using UnityEngine;
using System.Collections;


public class Damageable : MonoBehaviour {

	float timeSave;
	Timer timer;
	GameObject damageBG;
	Vector2 newPos;
	public GameObject damagePrefab;
	public float offsetLR;
	public float offsetUD;
	public int health;

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

			if(health == 0)
				Destroy (this.gameObject);
		}


		// Update position of damage background:
		if (damageBG) {
			newPos = this.transform.position;
			newPos.x += offsetLR;
			newPos.y += offsetUD;
			damageBG.transform.position = newPos;
		}
	}
	
	bool doDamage()
	{
		if (timer.isRunning ())
			return false;

		GetComponent<SpriteRenderer> ().color = Color.red;

		// Instantiate a damageBG only if one doesn't already exist:
		if(!damageBG)
			damageBG = Instantiate (damagePrefab);

		newPos = this.transform.position;
		newPos.x += offsetLR;
		newPos.y += offsetUD;
		damageBG.transform.position = newPos;

		health--;
		timer.set ();
		return true;
	}

	void clearDamage()
	{
		GetComponent<SpriteRenderer> ().color = Color.white;
		Destroy (damageBG);
	}
}
