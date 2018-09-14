using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	private float speed = 4;
	private Vector3 max = new Vector3 (-10f, 4.4f, 1);
	private Vector3 enemyPos;
	private bool up;
	private float maxup, maxdown;

	private void Start()
	{
		enemyPos = transform.position;
		maxup = enemyPos.y + 1f;
		maxdown = enemyPos.y - 1f;
		up = true;
	}


	void Update () {

		if (up == true)
		{
			enemyPos = new Vector3 (enemyPos.x - speed * Time.deltaTime, enemyPos.y + 2 * Time.deltaTime, 1);

			if (enemyPos.y >= maxup)
			{
				up = false;
			}
			
		}else
		{
			enemyPos = new Vector3 (enemyPos.x - speed * Time.deltaTime, enemyPos.y  - 2 * Time.deltaTime, 1);
			if (enemyPos.y <= maxdown)
			{
				up = true;
			}
		}

		transform.position = enemyPos;

		if (transform.position.x < max.x) {

			Destroy (gameObject);
		}
	}
}
