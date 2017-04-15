using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public float fireRate = .2f;
	public float fireCooldown;

	public GameObject[] bulletPrefabs;
	public GameObject bulletInstance;
	int iterator = 0;

	public GameObject muzzle;

	void Start () {
		
	}
	
	void Update () 
	{
		if (Input.GetButton ("Fire1"))
		{
			GameObject.Instantiate (bulletPrefabs [iterator % bulletPrefabs.Length], muzzle.transform.position, muzzle.transform.rotation);
			iterator ++;

			if (iterator > bulletPrefabs.Length)
				iterator = 0;
		}
	}
}
