using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSpawn : MonoBehaviour {

	public GameObject meteor;
	public GameObject meteorM;
	public GameObject meteorB;
	private float rand;
	public float spawnTime = 5f;

	// Use this for initialization
	void Start () {
		Invoke ("spawnMeteor", spawnTime);
	}

	void spawnMeteor() {

		Vector2 left = new Vector2 (-8f, 5f);
		Vector2 right = new Vector2 (8f, 5f);

		rand = Random.Range (1,3);

		if (rand == 1) {
			GameObject oneMeteor = (GameObject)Instantiate (meteor);
			oneMeteor.transform.position = new Vector2(Random.Range(left.x, right.x),left.y);
		}

		if (rand == 2) {

			GameObject oneMeteor = (GameObject)Instantiate (meteorM);
			oneMeteor.transform.position = new Vector2(Random.Range(left.x, right.x),left.y);
		}

		if (rand == 3) {

			GameObject oneMeteor = (GameObject)Instantiate (meteorB);
			oneMeteor.transform.position = new Vector2(Random.Range(left.x, right.x),left.y);
		}

		nextMeteor ();
	}

	void nextMeteor () {

		float spawnIn;

		if (spawnTime > 1f) {

			spawnIn = Random.Range (1f, spawnTime);
		} else {

			spawnIn = 1f;
		}

		Invoke ("spawnMeteor", spawnIn);
	}
}
