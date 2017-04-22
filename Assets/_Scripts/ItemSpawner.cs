using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSpawner : MonoBehaviour 
{
	//PUBLIC INSTANCES
	public GameObject log;
	public GameObject rock;
	//public GameObject flint;

//	public Button logSpawn;
//	public Button rockSpawn;
//	public Button useFlint;

	public int logCounter;
	public int rockCounter;
	//public bool hasFlint;

    // Use this for initialization
    void Start () 
	{
		logCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().logCounter;
		rockCounter = GameObject.Find("GameController").GetComponent<TransitioningScene>().rockCounter;
		//hasFlint = GameObject.Find("GameController").GetComponent<TransitioningScene>().hasFlint;
	}
	
//	// Update is called once per frame
//	void Update () 
//	{
//    }

	//Public Methods
	public void spawnLog()
	{
        //
        if (logCounter > 0) 
		{
			//Instantiating Log(s)
			Instantiate (log, GameObject.Find("ItemSpawner").transform.position, Quaternion.identity);
			//
			logCounter -= 1;
        }
	}

	public void spawnRock()
	{
        if (rockCounter > 0)
        {
			//Instantiating Rock(s)
            Instantiate(rock, GameObject.Find("ItemSpawner").transform.position, Quaternion.identity);
            //
            rockCounter -= 1;
        }
    }

//	public void spawnFlint()
//	{
//	}
}