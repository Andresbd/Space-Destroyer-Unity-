using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    public float moveSpeed;
    public float charHealth = 3;
    public float charShield = 3;
    public float charEnergy = 10;

    public Joystick joystick;

    void Awake()
    {
        charHealth = charHealth * upgradeMenu.UM.hpMultiply;
    }

    void FixedUpdate () 
	{
        //Movement
        Vector3 moveVector = (-transform.right * joystick.Horizontal + -transform.up * joystick.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed);

		Vector3 clampedMovement = transform.position;

		clampedMovement.x = Mathf.Clamp (transform.position.x, -8f,8f);
		clampedMovement.y = Mathf.Clamp (transform.position.y, -4.3f, 4.3f);

		transform.position = clampedMovement;

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		//all projectile colliding game objects should be tagged "Enemy" or whatever in inspector but that tag must be reflected in the below if conditional
		if(col.tag == "Enemy" || col.tag == "Meteor")
		{
			Damage ();
		}
	}

	void Damage () {

        charShield -= 1;

        if (charShield < 0) {

            charHealth -= 1;

            if (charHealth == 0)
            {
                gameManager.GM.EndGame();
                Destroy(gameObject);
            }
        }

		
	}
}
