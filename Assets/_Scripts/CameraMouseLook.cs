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
		//Setting the mouse (mouseDelta) to use the X and Y axes
		var mouseDelta = new Vector2 (Input.GetAxisRaw ("Mouse X"), Input.GetAxisRaw ("Mouse Y"));

		//Multiplying how sensitive the mouse moves with the smoothing varaible for the axes X and Y
		mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
		//Note: "Mathf.Lerp" makes the camera move "smoothly" rather than just moving straight from one place to another
		_smoothV.x = Mathf.Lerp (_smoothV.x, mouseDelta.x, 1f / smoothing);
		_smoothV.y = Mathf.Lerp (_smoothV.y, mouseDelta.y, 1f / smoothing);
		_mouseLook += _smoothV;

		//NOTE: Using the '-' makes the _mouseLook inverted
		transform.localRotation = Quaternion.AngleAxis(-_mouseLook.y, Vector3.right);
		//Making the actual character move rather than just the camera
		_character.transform.localRotation = Quaternion.AngleAxis (_mouseLook.x, _character.transform.up);

	}
}
