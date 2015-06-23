using UnityEngine;
using System.Collections;


public class DragonBody : MonoBehaviour {

	float timeSave;
	Timer timer;

	void Start()
	{
		timer = new Timer (.5f);
	}
	
	void OnCollisionEnter2D(Collision2D c)
	{
		GetComponent<SpriteRenderer> ().color = Color.red;
		timer.set();
	}

	void Update()
	{

		if (timer.check ()) {

			Debug.Log ("timer check passed");
			GetComponent<SpriteRenderer> ().color = Color.white;
		}
	}
}
