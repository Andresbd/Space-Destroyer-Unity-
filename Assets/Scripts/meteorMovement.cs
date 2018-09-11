using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorMovement : MonoBehaviour {

	public float speed = 3;

	// Update is called once per frame
	void Update () {

		Vector3 meteorPos = transform.position;

		meteorPos = new Vector3 (meteorPos.x, meteorPos.y - speed * Time.deltaTime, 1);

		transform.position = meteorPos;

		Vector3 max = new Vector3 (9f, -4.5f, 1);

		if (transform.position.y < max.y) {

			Destroy (gameObject);
		}
			
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Player")
		{
			Destroy (gameObject);
		}
	}
		
}
