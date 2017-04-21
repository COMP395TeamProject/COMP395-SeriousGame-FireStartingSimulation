using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountDownController : MonoBehaviour 
{
	float timeRemaining = 5;

	void Update()
	{
		timeRemaining -= Time.deltaTime;

	}

	void OnGUI()
	{
		if (timeRemaining > 0) 
		{
			GUI.Label (new Rect (100, 100, 200, 100), "Timer: " + timeRemaining);
		} 
		else
		{
			GUI.Label(new Rect(100, 100, 200, 100), "Game Over");
		}
	}
}
//	//Public Instance Variables
//	public Text txtTime;
//
//	//Private Instance Variables
//	private float _timeLeft = 300.0f;
//
//	void Update()
//	{
//		_timeLeft -= Time.deltaTime;
//		txtTime.text = "Time Left:" + Mathf.Round(_timeLeft); //
//		if(_timeLeft < 0)
//		{
//			Application.LoadLevel("GameOver");
//		}
//	}
//}