using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseLook : MonoBehaviour 
{
	//PUBLIC INSTANCE VARIABLES
	public float sensitivity = 5.0f; //mouse sensitivity
	public float smoothing = 2.0f; //manipulate how "smooth" the mouse's movement is

	//PRIVATE INSTANCE VARIABLES
	private GameObject _character; //declaring the character game object
	private Vector2 _mouseLook; //keeps track of the total movement of the controller
	private Vector2 _smoothV; //"Smooths" out the movement of the mouse

	// Use this for initialization
	void Start () 
	{
		//Referencing to camera object, thus making the character the "parent" object
		_character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//
		var mouseDelta = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));

		//

	}
}
