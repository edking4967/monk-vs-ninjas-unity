// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
using UnityEngine;
using AssemblyCSharp;

namespace Application
{
	public class Ninja : MonoBehaviour
	{
		AIState currentState;

		public void Start ()
		{
			currentState = new NinjaRunState ();
			currentState.doStart (this.gameObject);
		}

		public void FixedUpdate()
		{
			currentState.doFixedUpdate();
		}
	}
}
