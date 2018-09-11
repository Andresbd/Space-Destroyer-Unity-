using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

	private float speed = 4;
	private float Health = 5f;
	private int scoreValue = 5;
    private int goldValue = 1;
	
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

	void OnTriggerEnter2D(Collider2D col)
	{
		//all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
		if(col.tag == "Bullet")
		{
			Damage ();
            gameManager.GM.scoreNumber = gameManager.GM.scoreNumber + scoreValue;
		}

		if(col.tag == "Player")
		{
            gameManager.GM.gold = gameManager.GM.gold + goldValue;
			Destroy (gameObject);
		}
	}

	void Damage () {

		Health -= 1;

		if (Health == 0) {

			Destroy (gameObject);
		}
	}
}
