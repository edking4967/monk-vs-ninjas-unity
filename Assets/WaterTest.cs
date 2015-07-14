using UnityEngine;
using System.Collections;

public class WaterTest : MonoBehaviour {

	void OnTriggerStay2D(Collider2D Hit)
	{
		Hit.attachedRigidbody.AddForce (new Vector2(0, -6 * Hit.transform.position.y - Hit.attachedRigidbody.velocity.y*8));
	}

}
