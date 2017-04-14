using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeChildColors : MonoBehaviour {

	void ActivateAndChangeChildren()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			transform.GetChild (i).gameObject.SetActive (true);
		}

		this.BroadcastMessage ("ChangeNow", SendMessageOptions.DontRequireReceiver);
	}
}
