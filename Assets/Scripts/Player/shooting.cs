using UnityEngine;

public class shooting : MonoBehaviour {

	public GameObject bullet;

	Transform firePoint;

	void Awake () {
		
		firePoint = transform.Find ("bulletSpawn");

		if (firePoint == null) {

			Debug.LogError ("No firepoint");
		}
			
	}

	public void Shoot () {

		GameObject bulletShot = (GameObject)Instantiate (bullet);
		bulletShot.transform.position = firePoint.transform.position;
	}
}
