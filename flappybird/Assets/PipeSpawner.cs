using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public float maxYpos;
	public float spawnTime;
	public GameObject pipe;
	// Use this for initialization
	void Start () {
		startSpawning();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void startSpawning (){
		InvokeRepeating("spawnPipe",0.2f,spawnTime);

	}

	public void stopSpawning (){
		CancelInvoke("spawnPipe");
	}

	void spawnPipe (){
		Instantiate(pipe,new Vector3(transform.position.x,Random.Range(-maxYpos,maxYpos),0),Quaternion.identity);
	}
}
