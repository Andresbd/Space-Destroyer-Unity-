using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	private float speed = 4;
	
	// Update is called once per frame
	void Update () {

		Vector3 enemyPos = transform.position;

		enemyPos = new Vector3 (enemyPos.x - speed * Time.deltaTime, enemyPos.y, 1);

		transform.position = enemyPos;

		Vector3 max = new Vector3 (-10f, 4.4f, 1);

		if (transform.position.x < max.x) {

			Destroy (gameObject);
		}
	}
}
