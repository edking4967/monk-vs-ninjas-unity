using UnityEngine;
using System.Collections;
//using Application;

public class LoadOnClick : MonoBehaviour {
	
	public GameObject loadingImage;
	
	public void LoadScene(int level)
	{
		loadingImage.SetActive(true);
		UnityEngine.Application.LoadLevel(level);
	}
}