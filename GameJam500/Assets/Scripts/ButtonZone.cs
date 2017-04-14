using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonZone : MonoBehaviour {

	public bool triggered = false;
	public GameObject triggerTarget;
	public GameObject button;
	public Material activatedColor;

	void Start () {
		
	}
	
	void Update () 
	{
			
	}

	void OnTriggerStay()
	{
		if (Input.GetKey (KeyCode.E) && triggered == false)
		{
			triggered = true;
			triggerTarget.BroadcastMessage ("MoveToPosition", SendMessageOptions.DontRequireReceiver);
			button.transform.Translate (Vector3.down * .03f);
			button.GetComponent<MeshRenderer> ().material = activatedColor;
		}
	}
}
