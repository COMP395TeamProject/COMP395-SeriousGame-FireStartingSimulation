using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpController : MonoBehaviour 
{
	//Public Instance Variables
	public int distanceToitem;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Collect();
	}

	//Methods
	void Collect()
	{
		if (Input.GetMouseButtonUp (1)) 
		{
			RaycastHit hit; //
			//
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			//Nested - 
			if (Physics.Raycast (ray, out hit, distanceToitem)) 
			{
				//Nested nested - 
				if(hit.collider.gameObject.name == "pickupItem")
				{
					//Debugging
					Debug.Log("Item has been hit");
					Destroy (hit.collider.gameObject); //destroys the object named "item"
				}
			}
		}
	}
}