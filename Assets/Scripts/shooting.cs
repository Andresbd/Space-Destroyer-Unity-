using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {

	public float fireRate = 0f;
	public float damage = 10f;
	public GameObject bullet;

	Transform firePoint;

	// Use this for initialization
	void Awake () {
		
		firePoint = transform.Find ("bulletSpawn");

		if (firePoint == null) {

			Debug.LogError ("No firepoin");
		}
			
	}

	public void Shoot () {

		GameObject bulletShot = (GameObject)Instantiate (bullet);
		bulletShot.transform.position = firePoint.transform.position;
	}
}
