using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ItemPickUpController : MonoBehaviour 
{
	//Public Instance Variables
	//Referencing to SceneTransition
	public int distanceToitem;
    public int logCounter;
    public int rockCounter;

	public Image crossHair;
    //public bool has;

	// Use this for initialization
	void Start () 
	{
        // Find objects
        logCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().logCounter;
        rockCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().rockCounter;
        //has = GameObject.Find("Gamecontroller").GetComponent<TransitioningScene>().has;

        //Setting values
        logCounter = 0;
		rockCounter = 0;
		//has = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Collect();
	}

	//Methods
	void Collect()
	{
		if (Input.GetMouseButtonUp(0)) //GetKey(KeyCode.E) //GetMouseButtonUp(0)
		{
			RaycastHit hit; //
			//Ensuring the raycasting starts at the middle of the screen
			int centerX = Screen.width / 2;
			int centery = Screen.width / 2;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); //Input.mousePosition //new vector3(x,y);

			//Nested - 
			if (Physics.Raycast (ray, out hit, distanceToitem)) 
			{
				if(hit.collider.gameObject.tag == "log")
				{
					
					//Debugging
					Debug.Log("Log has been hit");
					Destroy (hit.collider.gameObject); //destroys the object named "item"
					logCounter += 1;
				}

				if(hit.collider.gameObject.tag == "rock")
				{

					//Debugging
					Debug.Log("Rock has been hit");
					Destroy (hit.collider.gameObject); //destroys the object named "item"
					rockCounter += 1;
				}

//				if(hit.collider.gameObject.tag == "")
//				{
//
//					//Debugging
//					Debug.Log("Item has been hit");
//					Destroy (hit.collider.gameObject); //destroys the object named "item"
//					has = true;
//				}

                //Change to "BuildingScene"
                if (logCounter >= 3 && rockCounter >= 4)
                {
                    SceneManager.LoadScene("BuildingScene");
                }
			}
		}

		//		var forward = transform.TransformDirection (Vector3.forward);
		//		RaycastHit rayHit;
		//
		//		if (Physics.Raycast (transform.position, forward, out rayHit)) 
		//		{
		//			if (rayHit.distance <= 10 && rayHit.collider.gameObject.tag == "log") 
		//			{
		//				if(Input.GetKey(KeyCode.E))
		//				{
		//					Destroy (gameObject);
		//				}
		//			}
		//		}
	}
}