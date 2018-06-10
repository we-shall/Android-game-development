using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

	// Use this for initialization

	public GameObject ball;
	public bool gameover;
	public float lerpRate;
	Vector3 offset;
	void Start () {
		gameover = false;
		offset = ball.transform.position - this.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		if (!gameover){

			follow();

		}
	}

	void follow(){
		Vector3 pos = this.transform.position;
		Vector3 targetPos = ball.transform.position - offset;
		pos = Vector3.Lerp(pos,targetPos,lerpRate*Time.deltaTime);
		transform.position = pos;


	}
}
