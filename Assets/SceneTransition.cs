using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour 
{
	//Public Instance Variable
	public int inventoryCount;

	// Use this for initialization
	void Start () 
	{
		//Don't destroy objects from previous scenes
		DontDestroyOnLoad ();
	}
}