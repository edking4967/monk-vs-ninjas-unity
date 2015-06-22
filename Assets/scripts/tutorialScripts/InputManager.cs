//////////////////////////////////////////////////////////////////////////////
// InputManager.cs
//////////////////////////////////////////////////////////////////////////////
// This object polls Unity for input and posts relevant GameEvents.
//////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
using GameEvents;

public class InputManager : MonoBehaviour
{
   ///////////////////////////////////////////////////////////////////////////
   // CLASS DATA
   ///////////////////////////////////////////////////////////////////////////
   
   //Keycodes for controls
   private KeyCode left = KeyCode.LeftArrow;
   private KeyCode right = KeyCode.RightArrow;
	private KeyCode jump = KeyCode.Space;
	private KeyCode fire = KeyCode.F;

   ///////////////////////////////////////////////////////////////////////////
   // FIXED UPDATE
   ///////////////////////////////////////////////////////////////////////////
	
	// Update is called once per frame
	void FixedUpdate () 
   {
        
      if(Input.GetKey(left))
         GameEventManager.post(new PlayerMoveEvent(Vector3.left));
         
      if(Input.GetKey(right))
         GameEventManager.post(new PlayerMoveEvent(Vector3.right));
         
		if (Input.GetKeyDown (jump))
			GameEventManager.post (new PlayerJumpEvent ());

		if (Input.GetKeyDown (fire)) {
			Debug.Log ("fire key pressed");
			GameEventManager.post (new PlayerFireEvent ());
		}

	}
}
