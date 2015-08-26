using UnityEngine;
using Application;
using System.Collections;

public class BasePlatform : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D c)
	{
		if(c.gameObject.GetComponent<GravitySprite> ())
			c.gameObject.GetComponent<GravitySprite>().land ();
	}

	public virtual void doThing() { }
}
