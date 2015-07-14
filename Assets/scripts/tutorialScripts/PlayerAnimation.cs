using UnityEngine;
using System.Collections;
using GameEvents;


public class PlayerAnimation : MonoBehaviour, GameEventListener {

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		//animator.Play("resting");
		GameEventManager.registerListener(this);	
	}
	
	///////////////////////////////////////////////////////////////////////////
	// EVENT LISTENING
	///////////////////////////////////////////////////////////////////////////
	
	public void eventReceived(GameEvent e)
	{
		if(e is PlayerMoveEvent)
			animator.Play ("running");

		if(e is PlayerJumpEvent)
			animator.Play ("jumping");

		if(e is PlayerStopEvent)
			animator.Play ("idle");

		if(e is PlayerHitEvent)
			animator.Play ("hit");

		if (e is PlayerFlipEvent) {
			Vector3 scale = transform.localScale;
			scale.x *= -1;
			transform.localScale = scale;
		}

	}
}
