using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	public float speed = 5.0f; 

	// Use this for initialization
	void Start ()
	{
		//"Locks" the mouse cursor when it's in the game window
		//Cursor.lockState = CursorLockMode.Locked;
	}    

	// Update is called once per frame
	void Update ()
	{
		float translation = 0; //
		float straffe = 0; // 

		//Movement
		if (Input.GetKey(KeyCode.A))
			straffe = -1f * speed;      
		if (Input.GetKey(KeyCode.D))
			straffe = 1f * speed;
		if (Input.GetKey(KeyCode.W))
			translation = 1f * speed;
		if (Input.GetKey(KeyCode.S))
			translation = -1f * speed;        

		//Rotation
		if (Input.GetKey(KeyCode.LeftArrow))
			this.transform.Rotate(0, -1f, 0);
		if (Input.GetKey(KeyCode.RightArrow))
			this.transform.Rotate(0, 1f, 0);
		/*if (Input.GetKey(KeyCode.UpArrow))
           this.transform.Rotate(-0.7f, 0, 0);
		if (Input.GetKey(KeyCode.DownArrow))
           this.transform.Rotate(0.7f, 0, 0);*/        

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