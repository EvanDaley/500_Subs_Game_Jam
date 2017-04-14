using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneChange : MonoBehaviour {

	public GameObject room;

	void OnTriggerEnter()
	{
		room.BroadcastMessage ("ActivateAndChangeChildren", SendMessageOptions.DontRequireReceiver);
	}
}
