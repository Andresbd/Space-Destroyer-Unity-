using UnityEngine;

public class playerMovement : MonoBehaviour {
	
	private float moveSpeed = 0.1f;
	public Joystick Joystick;
	
	void FixedUpdate () 
	{
		//Movement
		Vector3 moveVector = (-transform.right * Joystick.Horizontal + -transform.up * Joystick.Vertical).normalized;
		transform.Translate(moveVector * moveSpeed);

		Vector3 clampedMovement = transform.position;

		clampedMovement.x = Mathf.Clamp (transform.position.x, -8f,8f);
		clampedMovement.y = Mathf.Clamp (transform.position.y, -4.3f, 4.3f);

		transform.position = clampedMovement;

	}
}
