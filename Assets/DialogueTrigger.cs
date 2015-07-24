using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {
	public GUISkin skin;

	bool displayDialogue = false;

	void OnTriggerEnter2D(Collider2D c)
	{
		if(c.tag=="Player")
			displayDialogue = true;

	}

	void OnTriggerExit2D(Collider2D c)
	{
		if(c.tag=="Player")
			displayDialogue = false;
	}

	void OnGUI()
	{
		if (!displayDialogue)
			return;
		
		GUI.skin = skin;
		GUILayout.BeginArea(new Rect(50,50, 250,250));
		GUILayout.BeginVertical();
		GUILayout.Box("Hello.");
		GUILayout.EndVertical();
		
		GUILayout.EndArea ();
	}
}
