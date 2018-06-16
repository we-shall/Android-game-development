using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	[SerializeField]
	Transform player;
	Vector3 offset;

	[SerializeField]
	float smoothRate;


	// Use this for initialization
	void Start () {
		offset = player.position - this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		Vector3 currPos = transform.position;
		Vector3 newPos = player.position - offset;
		currPos = Vector3.Lerp (currPos, newPos, smoothRate*Time.deltaTime);
		transform.position = currPos;

	}
}
