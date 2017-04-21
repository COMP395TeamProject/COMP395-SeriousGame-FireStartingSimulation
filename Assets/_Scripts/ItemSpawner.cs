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
		hasFlint = GameObject.Find("GameController").GetComponent<TransitioningScene>().hasFlint;
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
			Instantiate (log, GameObject.Find("ItemSpawner").transform.position, Quaternion.identity);
			//
			logCounter -= 1;

            
        }
	}

	public void spawnRock()
	{
        if (rockCounter > 0)
        {
            //Instantiating Objects
            Instantiate(rock, GameObject.Find("ItemSpawner").transform.position, Quaternion.identity);
            //
            rockCounter -= 1;

        }
    }

	public void spawnFlint()
	{

	}

}
