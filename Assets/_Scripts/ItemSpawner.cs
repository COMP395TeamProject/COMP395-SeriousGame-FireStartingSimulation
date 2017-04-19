using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour 
{
	//Public Instance
	public GameObject log;
	public GameObject rock;
	public GameObject flint;
	public int logCounter;
	public int rockCounter;
	public bool hasFlint;

	// Use this for initialization
	void Start () 
	{
		logCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().logCounter;
		rockCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().rockCounter;
		hasFlint = GameObject.Find("Gamecontroller").GetComponent<TransitioningScene>().hasFlint;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	//Public Methods
	public void spawnLog()
	{
		//
		if (logCounter > 0) 
		{
			//Instantiating Objects
			Instantiate (log, transform.position, transform.rotation);
			//
			logCounter -= 1;
		}

	}

	public void spawnRock()
	{

	}

	public void spawnFlint()
	{

	}

}
