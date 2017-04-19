using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public GameObject muzzle;
	public float fireRate = .2f;
	private float fireCooldown;

	public GameObject[] bulletPrefabs;
	int iterator = 0;
	
	void Update () 
	{
		if (Input.GetButton ("Fire1") && Time.time > fireCooldown)
		{
			fireCooldown = Time.time + fireRate;

			GameObject.Instantiate (bulletPrefabs [iterator], muzzle.transform.position, muzzle.transform.rotation);
			iterator = (iterator + 1) % bulletPrefabs.Length;
		}
	}
}
