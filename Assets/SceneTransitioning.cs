using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitioning : MonoBehaviour 
{
	public bool hasFlint;
	public int logCounter;
	public int rockCounter;

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
