using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager instance;
	public int score;

	// Use this for initialization

	void Awake (){
		if (instance == null) 
			instance = this;
	}
	void Start () {
		score = 0;
		PlayerPrefs.SetInt("score",score);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void incrementScore (){
		score  += 1;
	}

	public void StopScore (){
		PlayerPrefs.SetInt("score",score);
		if (PlayerPrefs.HasKey("highscore")){
			if (score > PlayerPrefs.GetInt("highscore"))
				PlayerPrefs.SetInt("highscore",score);
		}
		else
		{
			PlayerPrefs.SetInt ("highscore",score);
		}
	}
}
