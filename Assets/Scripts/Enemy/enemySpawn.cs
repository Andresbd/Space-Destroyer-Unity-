using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawn : MonoBehaviour {

	public float spawnTime = 6f;

	// Use this for initialization
	void Start () {
		Invoke ("spawnEnemy", spawnTime);
		InvokeRepeating ("increaseSpeed", 0f, 30f);
	}

	public void spawnEnemy(GameObject enemy) {

		Vector2 bottom = new Vector2 (10f, -3.3f);
		Vector2 top = new Vector2 (10f, 3.3f);

		GameObject oneEnemy = (GameObject)Instantiate (enemy);
		oneEnemy.transform.position = new Vector2(top.x, Random.Range(top.y, bottom.y));

		nextEnemy ();
	}

	void nextEnemy () {

		float spawnIn;

		if (spawnTime > 1f) {

			spawnIn = Random.Range (1f, spawnTime);

		} else {

			spawnIn = 1f;
		}

		Invoke ("spawnEnemy", spawnIn);
	}

	void increaseSpeed () {

		if (spawnTime > 1f) {

			spawnTime -= 1;
		}

		if (spawnTime == 1f) {

			CancelInvoke ("increaseSpeed");
		}
	}
}
