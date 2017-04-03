using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	//public float x, z;
	public float speed = 10.0f; //setting speed variable

	// Use this for initialization
	void Start () 
	{
		//		//Setting the horizontal and vertical input to the x and y axis respectively
		//		x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		//		z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		//"Locks" the mouse cursor when it's in the game window
		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update () 
	{
		//		//Manipulating the player's rotation and movement
		//		transform.Rotate(0, x, 0); //using the var x to "rotate"
		//		transform.Translate(0, 0, z);
		//
		//		//		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		//		//		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
		//		//
		//		//		transform.Rotate(0, x, 0);
		//		//		transform.Translate(0, 0, z);

		//translation holds the forwards and backwards movement
		float translation = Input.GetAxis ("Vertical") * speed; 
		//straffe holds the sideways movement
		float straffe = Input.GetAxis ("Horizontal") * speed;
		//Updating the movement by multiplying the "movement" variables by real time in seconds
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		//This is what pushes the player's movement
		transform.Translate(straffe, 0, translation);

		//UNNECESSARY!!! - Enables mouse freedom
		if (Input.GetKeyDown ("escape")) 
		{
			Cursor.lockState = CursorLockMode.None;
		}
	}
}