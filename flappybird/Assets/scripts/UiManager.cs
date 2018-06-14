using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {


	public static UiManager instance;
	public Text scoretext;
	public GameObject gameoverpanel;
	public GameObject gameovertext;
	public Text highscore;

	void Awake(){
		if (instance == null)
			instance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		scoretext.text = ScoreManager.instance.score.ToString();
	}

	public void Replay(){
		SceneManager.LoadScene (1);
	}

	public void Menu(){
		SceneManager.LoadScene (0);		
	}

	public void Gameover(){

		highscore.text = "Highscore: " + PlayerPrefs.GetInt("highscore").ToString();
		gameovertext.SetActive(true);
		gameoverpanel.SetActive(true);
	}
}
