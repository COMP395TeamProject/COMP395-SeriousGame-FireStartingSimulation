using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICanvasController : MonoBehaviour 
{
	//Public Instances
	//NOTE: These instances refers to the "txt" counterpart compoenents due to me adding the button component on the "txt"s
	public Button btnStart;
	public Button btnInfo;
	public Button btnMenu;
	public Button btnExit;
    
    //public Button btnReset;

    //	//Initialization
    //	public void Start()
    //	{
    //		Initializing instance varaibles to corresponding components
    //		btnBegin = btnBegin.GetComponent<Button>();
    //		btnInfo = btnInfo.GetComponent<Button>();
    //		btnExit = btnExit.GetComponent<Button>();
    //	}

    //Public Methods
    //begins simulation by changing to "MainScene"
    public void StartMainScene()
	{
		SceneManager.LoadScene ("MainScene");
	}

	//Change scene to "InfoScene"
	public void ChangeToInfoScene()
	{
		SceneManager.LoadScene ("InfoScene");
	}

	//Change scene to "MenuScene"
	public void ChangeToMenuScene()
	{
		SceneManager.LoadScene ("MenuScene");
	}

//	//Restarts "MainScene"
//	public void ResetMainScene()
//	{
//		SceneManager.LoadScene ("MainScene");
//	}

	//Quits Game
	public void Quit()
	{
		Application.Quit();
	}
}