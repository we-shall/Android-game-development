using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public bool gameover;

	void Awake (){
		DontDestroyOnLoad(this.gameObject);
		if (instance == null)
			instance = this;
		else
			Destroy (this.gameObject);
	}
	// Use this for initialization
	void Start () {
		gameover = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GameStart(){
		GameObject.Find("pipeSpawner").GetComponent<PipeSpawner>().startSpawning();
	}

	public void GameOver(){
		gameover = false;
		GameObject.Find("pipeSpawner").GetComponent<PipeSpawner>().stopSpawning();
		ScoreManager.instance.StopScore();
		UiManager.instance.Gameover();
	}
}
