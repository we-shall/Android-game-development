using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	Rigidbody2D rb;
	public bool started;
	public float upforce;
	public bool gameover;
	public float rotate;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		started = false;
		gameover = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!started){
			if (Input.GetMouseButtonDown(0))
			{
				started = true;
				rb.isKinematic = false;
				GameManager.instance.GameStart();
			}
		}
		else if (started && !gameover)
		{
			transform.Rotate(0,0,rotate);
			if (Input.GetMouseButtonDown(0))
				{
					rb.velocity = Vector2.zero;
					rb.AddForce(new Vector2(0,upforce));
				}
		}

	}

	void OnCollisionEnter2D (Collision2D col){
		gameover = true;
		GameManager.instance.GameOver();
		GetComponent <Animator> ().Play("ballanim");
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "pipe" && !gameover)
		{
			//ScoreManager.instance.StopScore();
			gameover = true;
			GameManager.instance.GameOver();
			GetComponent <Animator> ().Play("ballanim");
		}

		if (col.gameObject.tag == "scorechecker" && !gameover)
			ScoreManager.instance.incrementScore();
	}
}
