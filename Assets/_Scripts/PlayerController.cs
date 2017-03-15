using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	public float x, z;

	// Update is called once per frame
	void Start () 
	{
		//Setting the horizontal and vertical input to the x and y axis respectively
		x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
	}
		
	// Update is called once per frame
	void Update () 
	{
		//Manipulating the player's rotation and movement
		transform.Rotate(0, x, 0); //using the var x to "rotate"
		transform.Translate(0, 0, z);

//		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
//		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
//
//		transform.Rotate(0, x, 0);
//		transform.Translate(0, 0, z);
	}
}