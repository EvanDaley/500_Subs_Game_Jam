using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedScenery : MonoBehaviour {

	private Vector3 startPosition;
	private Quaternion startRotation;
	private bool shouldMove = false;
	public float moveSpeed = 1f;
	public float restHeight = -5f;

	void Start () {
		startPosition = transform.position;
		Vector3 restPosition = startPosition;
		restPosition.y = restHeight;
		transform.position = restPosition;
	}
	
	void Update () 
	{
		if (shouldMove)
		{
			transform.position = Vector3.MoveTowards (transform.position, startPosition, moveSpeed * Time.deltaTime);
		}
	}

	public void MoveToPosition()
	{
		shouldMove = true;
	}
}
