using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour 
 {
	//Instance Varaibles
 	float distance = 10f;

	//Methods
	void onMouseDrag()
	{
		//
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		//
		Vector3 objectPosition = Camera.main.ScreenToWorldPoint (mousePosition);

		//
		transform.position = objectPosition;
	}

}