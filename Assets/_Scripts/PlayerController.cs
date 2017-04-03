using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	public float speed = 10.0f; //setting speed variable

	// Use this for initialization
	void Start () 
	{
		//"Locks" the mouse cursor when it's in the game window
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () 
	{
		//translation holds the forwards and backwards movement
		float translation = Input.GetAxis ("Vertical") * speed; 
		//straffe holds the sideways movement
		float straffe = Input.GetAxis ("Horizontal") * speed;
		//Updating the movement by multiplying the "movement" variables by real time in seconds
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		//This is what pushes the player's movement
		transform.Translate(straffe, 0, translation);

		//Conditional used to show mouse cursor by pressing the "ESC" button
		if (Input.GetKeyDown ("escape")) 
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}
}