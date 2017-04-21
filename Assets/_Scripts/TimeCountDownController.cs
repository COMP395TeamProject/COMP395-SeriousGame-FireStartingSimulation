using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountDownController : MonoBehaviour 
{
	//Public Instance Variables
	public Text text;

	//Private Instance Variables
	private float _timeLeft = 300.0f;

	void Update()
	{
		_timeLeft -= Time.deltaTime;
		text.text = "Time Left:" + Mathf.Round(_timeLeft); //
		if(_timeLeft < 0)
		{
			Application.LoadLevel("GameOver");
		}
	}
}