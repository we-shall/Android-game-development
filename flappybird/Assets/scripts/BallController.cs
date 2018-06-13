using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	Rigidbody2D rb;
	public bool started;
	public float upforce;

	// Use this for initialization
	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		started = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!started){
			if (Input.GetMouseButtonDown(0))
			{
				started = true;
				rb.isKinematic = false;
			}
		}
		else
		{
			if (Input.GetMouseButtonDown(0))
				{
					rb.velocity = Vector2.zero;
					rb.AddForce(new Vector2(0,upforce));
				}
		}

	}
}
