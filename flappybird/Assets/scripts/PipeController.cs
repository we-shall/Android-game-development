using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {

	public int speed;
	public int speedInUpDown;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		MoveLeft();
		InvokeRepeating("switchUpDown",0.1f,1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void MoveLeft() {
		rb.velocity = new Vector2(-speed,speedInUpDown);
	}

	void switchUpDown (){
		speedInUpDown = -speedInUpDown;
		rb.velocity = new Vector2(-speed,speedInUpDown);

	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "removepipe")
			Destroy (gameObject);
	}
}
