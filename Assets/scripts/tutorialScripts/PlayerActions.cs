using UnityEngine;
using System.Collections;
using GameEvents;


public class PlayerActions : MonoBehaviour, GameEventListener {
	
	// Use this for initialization
	void Start () {
		GameEventManager.registerListener(this);	
	}
	
	///////////////////////////////////////////////////////////////////////////
	// EVENT LISTENING
	///////////////////////////////////////////////////////////////////////////
	
	public void eventReceived(GameEvent e)
	{
		if (e is PlayerFireEvent) {
			Debug.Log ("send fireProjectile");
			GetComponent<MonkController>().fireProjectile();
		}
	}
}
