using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemPickuUp : MonoBehaviour 
{
	//Public Instance Variables
	public int distanceToitem;

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
							SceneManager.LoadScene ("BuildingScene");
							//Debugging
//							Debug.Log("Item has been hit");
//							Destroy (hit.collider.gameObject); //destroys the "item"
						}
					}
		
				}
	}

//	void ChangeToBuildingScene()
//	{
//		SceneManager.LoadScene ("BuildingScene");
//	}
}