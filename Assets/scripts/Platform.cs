using UnityEngine;
using Application;
using System.Collections;

public class Platform : MonoBehaviour {
	
	public void OnCollisionEnter2D(Collision2D c)
	{
		if(c.gameObject.GetComponent<GravitySprite> ())
			c.gameObject.GetComponent<GravitySprite>().land ();

	}
}
