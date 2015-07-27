using UnityEngine;
using Application;
using System.Collections;

public class Platform : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D c)
	{
		Debug.Log ("collider triggered");
		if(c.gameObject.GetComponent<GravitySprite> ())
			c.gameObject.GetComponent<GravitySprite>().land ();
	}

}
