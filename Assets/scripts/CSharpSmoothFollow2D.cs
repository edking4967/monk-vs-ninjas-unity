using UnityEngine;
using System.Collections;

public class CSharpSmoothFollow2D : MonoBehaviour 
{
	public Transform target;
	public float smoothTime = 0.3f;
	private Transform thisTransform;
	private Vector2 velocity;
	public bool allowedToMove=true;
	
	private void Start()
	{
		thisTransform = transform;
	}
	
	private void Update() 
	{
		if (allowedToMove) {
			Vector3 vec = thisTransform.position;
			vec.x = Mathf.SmoothDamp (thisTransform.position.x, 
		                         target.position.x, ref velocity.x, smoothTime);
			vec.y = Mathf.SmoothDamp (thisTransform.position.y, 
		                         target.position.y, ref velocity.y, smoothTime);
			thisTransform.position = vec;
		}
	}
}