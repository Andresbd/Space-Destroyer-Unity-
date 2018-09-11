using UnityEngine;

public class PlayerExample : MonoBehaviour {

    public float moveSpeed;
    public Joystick joystick;

	void Update () 
	{
		Vector3 moveVector = (-transform.right * joystick.Horizontal + -transform.up * joystick.Vertical).normalized;
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
	}
}