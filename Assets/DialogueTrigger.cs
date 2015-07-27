using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {
	public GUISkin skin;

	bool displayDialogue = false;

	string [] dialogues = {"Hello", "Are you ready for an adventure?"};
	int dialogueNum;

	public void Start()
	{
		dialogueNum = 0;
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			resetDialogue();
			displayDialogue = true;
		}

		if (displayDialogue && c.tag == "Projectile") {
			advanceDialogue();
		}
	}

	void OnTriggerExit2D(Collider2D c)
	{
		if(c.tag=="Player")
			displayDialogue = false;
	}

	void resetDialogue()
	{
		dialogueNum = 0;
	}

	void advanceDialogue()
	{
		if (dialogueNum < dialogues.Length)
			dialogueNum++;
		else
			dialogueNum = 0;
	}

	void OnGUI()
	{
		if (!displayDialogue)
			return;
		
		GUI.skin = skin;
		GUILayout.BeginArea(new Rect(50,50, 250,250));
		GUILayout.BeginVertical();

		//Texture myTex = (Texture)Resources.Load ("monkMed", typeof(Texture));
		//GUILayout.Box(myTex);

		GUILayout.Box(dialogues[dialogueNum]);
		GUILayout.EndVertical();
		
		GUILayout.EndArea ();
	}
}
