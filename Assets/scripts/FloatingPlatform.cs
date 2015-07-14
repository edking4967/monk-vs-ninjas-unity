using UnityEngine;
using System.Collections;

public class FloatingPlatform : Platform {

    Rigidbody2D rb;
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    } 

	void OnTriggerStay2D(Collider2D hit)
	{
		if (hit.gameObject.name == "Monk")
			Debug.Log ("aww that ol monk!");
	}

}
