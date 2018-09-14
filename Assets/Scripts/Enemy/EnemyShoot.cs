using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

	public GameObject bullet;
	private int _shootTime;
	Transform firePoint;

	void Awake () {
		
		firePoint = transform.Find ("bulletSpawn");
		_shootTime = 50;

		if (firePoint == null) {

			Debug.LogError ("No firepoint");
		}
			
	}

	private void Update()
	{
		_shootTime -= 1;

		if (_shootTime <= 0)
		{
			_shootTime = 50;
			Shoot();
		}
	}

	public void Shoot () {

		GameObject bulletShot = (GameObject)Instantiate (bullet);
		bulletShot.transform.position = firePoint.transform.position;
	}
}
