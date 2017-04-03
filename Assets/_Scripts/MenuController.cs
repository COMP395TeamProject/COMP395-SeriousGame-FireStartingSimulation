using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour 
{
	//Public Instances
	//NOTE: These instances refers to the "txt" counterpart compoenents due to me adding the button component on the "txt"s
	public Button btnStart;
	public Button btnInfo;
	public Button btnMenu;
	public Button btnExit;
	//public Button btnReset;

	//Initialization
	public void Start()
	{
		//Initializing instance varaibles to corresponding components
		//btnBegin = btnBegin.GetComponent<Button>();
		//btnInfo = btnInfo.GetComponent<Button>();
		//btnExit = btnExit.GetComponent<Button>();
	}

	//Public Methods
	//begins simulation by changing to "MainScene"
	public void BeginSimulation()
	{
		SceneManager.LoadScene ("MainScene");
	}

//	//Change scene to "InfoScene"
//	public void ChangeToOverviewScene()
//	{
//		SceneManager.LoadScene ("InfoScene");
//	}

	//Change scene to "MenuScene"
	public void BackToMenuScene()
	{
		SceneManager.LoadScene ("MenuScene");
	}

	//Quites Game
	public void Reset()
	{
		SceneManager.LoadScene ("MainScene");
	}

	//Quites Game
	public void Exit()
	{
		Application.Quit();
	}
}