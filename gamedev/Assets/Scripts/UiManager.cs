using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

	// Use this for initialization

	public static UiManager instance;

	public GameObject zigzagPanel;
	public GameObject gameOverPanel;
	public GameObject taptext;
	public Text score;
	public Text HighScore1;
	public Text HighScore2;

	void Awake (){

		if (instance == null)
			instance = this;
	}

	void Start () {
		HighScore1.text = "HighScore: " + PlayerPrefs.GetInt ("highScore").ToString();


	}

	public void GameStart (){

		taptext.SetActive(false);
		zigzagPanel.SetActive (false);

		//zigzagPanel.GetComponent<Animator> ().Play("PanelUp");

	}

	public void GameOver (){
		score.text = PlayerPrefs.GetInt ("score").ToString();
		gameOverPanel.SetActive(true);
		HighScore2.text = PlayerPrefs.GetInt ("highScore").ToString();

	}

	public void Reset (){
		SceneManager.LoadScene(0);
	}
	
	// Update is called once per frame
	void Update () {
		



	}
}
