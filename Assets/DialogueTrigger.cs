using UnityEngine;
using System.Collections;

public class DialogueTrigger : MonoBehaviour {
	public GUISkin skin;
	public TextAsset dialogueAsset;

	bool displayDialogue = false;

	string [] dialogues ;
	string dialogue;
	int dialogueNum;

	public void Start()
	{
		dialogue  = dialogueAsset.text;
		dialogues = dialogue.Split ('\n');
		dialogueNum = 0;
		Debug.Log (dialogues.Length);
	}

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.tag == "Player") {
			resetDialogue();
			displayDialogue = true;
		}

		if (displayDialogue && c.tag == "Projectile") {
			advanceDialogue();
			Destroy(c.gameObject);
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
		if (dialogueNum < dialogues.Length )
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

		if (dialogueNum != dialogues.Length) 
			GUILayout.Box(dialogues[dialogueNum]);
		GUILayout.EndVertical();
		
		GUILayout.EndArea ();
	}
}
