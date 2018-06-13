using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	// Use this for initialization

	public static ScoreManager instance;
	public int score;
	public int highScore;

	void Awake(){

		if (instance == null)
			instance = this;
	}

	void Start () {
		PlayerPrefs.SetInt ("score",score);
		score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void IncrementScore (){

		score += 1;

	}

	public void StartScore (){

		InvokeRepeating ("IncrementScore",0.1f,0.5f);
	}

	public void StopScore (){

		CancelInvoke ("IncrementScore");
		PlayerPrefs.SetInt ("score",score);

		if (PlayerPrefs.HasKey("highScore")){
			if (PlayerPrefs.GetInt("highScore") < score)
				PlayerPrefs.SetInt("highScore",score);
		}
		else{
			PlayerPrefs.SetInt("highScore",score);
		}

	}
}
