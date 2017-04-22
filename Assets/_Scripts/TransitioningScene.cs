using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitioningScene : MonoBehaviour 
{

	//Public Instance
	public int logCounter;
	public int rockCounter;
	//public bool hasFlint;
	public Text finalCountDown; //doesn't work...

	// Use this for initialization
	void Start () 
	{
		//Game Objects including "logs" and "rocks" will "put" into a collection in between "MainScene" and "BuildingScene"
		DontDestroyOnLoad (transform.gameObject); 
		//INCLUDE THE "txt_timer" FROM "MainScene" TO "BuildingScene" IN HERE!
	}

//	// Update is called once per frame
//	void Update () 
//	{
//	}
}