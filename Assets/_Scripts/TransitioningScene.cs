using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitioningScene : MonoBehaviour 
{

	//Public Instance
	public int logCounter;
	public int rockCounter;
	public bool hasFlint;

	// Use this for initialization
	void Start () 
	{
		DontDestroyOnLoad (transform.gameObject);
	}

	// Update is called once per frame
	void Update () 
	{

	}
}