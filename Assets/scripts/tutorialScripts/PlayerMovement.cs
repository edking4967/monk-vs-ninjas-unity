//////////////////////////////////////////////////////////////////////////////
// PlayerMovement.cs
//////////////////////////////////////////////////////////////////////////////
// This script listens for PlayerMoveEvents and moves the attached object
// accordingly.
//////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
using GameEvents;
using Application;

public class PlayerMovement : MonoBehaviour, GameEventListener 
{

   ///////////////////////////////////////////////////////////////////////////
   // CONSTANTS
   ///////////////////////////////////////////////////////////////////////////
   
   const float moveAmount = 0.05f;

   ///////////////////////////////////////////////////////////////////////////
   // START FUNCTION
   ///////////////////////////////////////////////////////////////////////////

	// Use this for initialization
	void Start () 
   	{
      GameEventManager.registerListener(this);	
	}
	
   ///////////////////////////////////////////////////////////////////////////
   // EVENT LISTENING
   ///////////////////////////////////////////////////////////////////////////
   
   public void eventReceived(GameEvent e)
   {
		if (e is PlayerMoveEvent)
		{
			Vector3 d = (e as PlayerMoveEvent).direction;

			GetComponentInParent<GravitySprite>().run(d);

			handlePlayerFlip(d);
		}

		if (e is PlayerJumpEvent) {
			GetComponent<GravitySprite>().jump();
		}
   }

	private void handlePlayerFlip(Vector3 d)
	{
		bool isFacingRight = GetComponentInParent<MonkController>().isFacingRight;
		
		if(isFacingRight && d == Vector3.left)
		{
			Debug.Log("change direction");
			GetComponentInParent<MonkController>().isFacingRight=false;

			GameEventManager.post(new PlayerFlipEvent());


		}
		if(!isFacingRight && d == Vector3.right)
		{
			Debug.Log("change direction");
			GetComponent<MonkController>().isFacingRight=true;
			
			GameEventManager.post(new PlayerFlipEvent());
		}
		
	}
	
}
