using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider))]
public class GameManager : MonoBehaviour
{
	private GameObject monk;
	void Start()
	{
		Debug.Log ("hello");
		monk = GameObject.Find ("Monk");
		Debug.Log (monk.GetType().ToString());
	}

	/*
	void OnGUI() {
		Event e = Event.current;
		MonkController ma = monk.GetComponent<MonkController>();

		if (e.isKey && e.keyCode == KeyCode.Space && !ma.isJumping) {
			Debug.Log ("Detected key code: " + e.keyCode);
			ma.jump();
		}
	}
	*/

	void Update()
	{
		//Debug.Log ("update!");
	}

}
