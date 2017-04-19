using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float moveForce = 100f;
	public Rigidbody rbody;

	void Start () {
		rbody.AddForce (transform.forward * moveForce);
	}
}
