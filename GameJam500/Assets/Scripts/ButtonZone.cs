using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonZone : MonoBehaviour {

	public bool triggered = false;
	public GameObject triggerTarget;

	void Start () {
		
	}
	
	void Update () 
	{
			
	}

	void OnTriggerStay()
	{
		if (Input.GetKey (KeyCode.E))
		{
			triggerTarget.BroadcastMessage ("MoveToPosition", SendMessageOptions.DontRequireReceiver);
		}
	}
}
