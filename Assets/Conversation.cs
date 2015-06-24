using UnityEngine;
using System.Collections;

public class Conversation : MonoBehaviour {
	public GUISkin skin;
	
	string scene = "start";
	
	void OnGUI()
	{
		GUI.skin = skin;
		
		
		GUILayout.BeginArea(new Rect(50,50, 250,250));
		
		if(scene == "start")
		{
			GUILayout.BeginVertical();
			GUILayout.Label("Howdy.");
			
			if(GUILayout.Button("O hai."))
			{
				scene = "hello";
			}
			
			if(GUILayout.Button("Where the party is?"))
			{
				scene = "party";
			}
			
			GUILayout.EndVertical();
		}
		else if(scene == "hello")
		{
			GUILayout.BeginVertical();
			GUILayout.Label("Cool talk to you later.");
			GUILayout.EndVertical();
		}
		else if(scene == "party")
		{
			GUILayout.BeginVertical();
			GUILayout.Label("I would also like to know.");
			GUILayout.EndVertical();
		}
		
		GUILayout.EndArea();
	}
}
