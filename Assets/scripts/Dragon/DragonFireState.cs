// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using UnityEngine;
using System;
using AssemblyCSharp;

namespace Application
{
	public class DragonFireState: AIState
	{
		Timer fireTimer;
		Dragon dragon;
		Rigidbody2D rb;

		public DragonFireState  ()
		{
		}

		public override void doFixedUpdate()
		{
			// Float in the air:
			rb.AddForce (new Vector2 (0, 9.81f));

			if (fireTimer.check ()) {
				dragon.fireProjectile();
				fireTimer.set();
			}
		}

		public override void doStart(GameObject g)
		{
			fireTimer = new Timer (1);
			
			fireTimer.set ();
			
			dragon = GameObject.Find ("dragon").GetComponent<Dragon> ();

			rb = GameObject.Find ("dragon").GetComponent<Rigidbody2D> ();
		}

	}
}

