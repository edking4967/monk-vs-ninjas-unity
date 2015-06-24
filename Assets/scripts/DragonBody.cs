using UnityEngine;
using System.Collections;


public class DragonBody : MonoBehaviour {

	float timeSave;
	Timer timer;
	public int health = 10;

	void Start()
	{
		timer = new Timer (.2f);
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if (!timer.isRunning()) {
			GetComponent<SpriteRenderer> ().color = Color.red;
			timer.set ();
			health -= 1;
		}
	}

	void Update()
	{
		if (timer.check()) {

			Debug.Log ("timer check passed");
			GetComponent<SpriteRenderer> ().color = Color.white;
		}

		if (health == 0) {
			Destroy(gameObject);
		}
	}
}