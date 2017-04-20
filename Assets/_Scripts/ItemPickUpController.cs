using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpController : MonoBehaviour 
{
	//Public Instance Variables
	//Referencing to SceneTransition
	public int distanceToitem;
    public int logCounter;
    public int rockCounter;
    public bool hasFlint;

	// Use this for initialization
	void Start () 
	{
        // Find objects
        logCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().logCounter;
        rockCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().rockCounter;
        //hasFlint = GameObject.Find("Gamecontroller").GetComponent<TransitioningScene>().hasFlint;

        //Setting values
        logCounter = 0;
		rockCounter = 0;
		//hasFlint = false;
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
				//Nested nested - log
				if(hit.collider.gameObject.tag == "log")
				{
					
					//Debugging
					Debug.Log("Item has been hit");
					Destroy (hit.collider.gameObject); //destroys the object named "item"
					logCounter += 1;
				}
				//Nested nested - 
				if(hit.collider.gameObject.tag == "rock")
				{

					//Debugging
					Debug.Log("Item has been hit");
					Destroy (hit.collider.gameObject); //destroys the object named "item"
					rockCounter += 1;
				}
				//Nested nested - 
				if(hit.collider.gameObject.tag == "flint")
				{

					//Debugging
					Debug.Log("Item has been hit");
					Destroy (hit.collider.gameObject); //destroys the object named "item"
					hasFlint = true;
				}
			}
		}
	}
}