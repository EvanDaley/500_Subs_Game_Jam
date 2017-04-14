using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	public Material newMaterial;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeNow()
	{
		this.GetComponent<MeshRenderer> ().material = newMaterial;
		print (gameObject.name + " Changing");
	}
}
