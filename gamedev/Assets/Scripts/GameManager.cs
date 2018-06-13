using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public bool gameover;



	void Awake (){
		if (instance == null)
			instance = this;
	}
	// Use this for initialization
	void Start () {
		gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartGame (){
		UiManager.instance.GameStart();
		ScoreManager.instance.StartScore ();
		GameObject.Find("platformSpawner").GetComponent <SpawnBlocks> ().spawnOnGameStart ();

	}

	public void GameOver (){
		UiManager.instance.GameOver ();
		ScoreManager.instance.StopScore();
		gameover = true;
	}
}
