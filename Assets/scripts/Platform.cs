using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c)
	{
		Debug.Log ("collider triggered");
		GameObject monk = GameObject.Find ("Monk");

		monk.GetComponent<MonkController> ().land ();
	}


}
