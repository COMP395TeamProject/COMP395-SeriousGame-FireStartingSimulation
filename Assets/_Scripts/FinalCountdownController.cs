using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalCountdownController : MonoBehaviour 
{
	//Public Instance Variables
	public Text txtFinalCountdown;

	//Private Instance Variables
	private float _timeStart = 300.0f; //starts at 5 minutes

	void Update()
	{
		//Decrementing 5 minutes by one second (in real time)
		_timeStart -= Time.deltaTime;
		txtFinalCountdown.text = "Time Left:" + Mathf.Round(_timeStart); //

		//Converting float to string and placing relevant time to "minutes" and "secons" strings.
		string minutes = ((int) _timeStart / 60).ToString();
		string seconds = (_timeStart % 60).ToString ("f2");

		//Concatenation to Text's String
		txtFinalCountdown.text = ("Final Countdown: " + minutes + ":" + seconds);

		if(_timeStart <= 0)
		{
			SceneManager.LoadScene("GameOver");
		}
	}
}