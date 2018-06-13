using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoller : MonoBehaviour {
	[SerializeField]
	private float speed;
	private bool start;
	Rigidbody rb;
	private bool gameover;
	public GameObject particle;
	// Use this for initialization

	void Awake(){

		rb = GetComponent<Rigidbody> ();

	}

	void Start () {
		start = false;
		gameover = false;
	}
	
	// Update is called once per frame
	void Update () {

		if(!start){
			if (Input.GetMouseButtonDown(0))
				{
					rb.velocity = new Vector3(speed,0,0);
					start = true;
					GameManager.instance.StartGame ();
				}
		}
		if (!Physics.Raycast(transform.position,Vector3.down,1f))
			{
				gameover = true;
				rb.velocity = new Vector3(0,-25,0);
				Camera.main.GetComponent<CameraMover> ().gameover = true;

				GameManager.instance.GameOver();
			}

		if (Input.GetMouseButtonDown(0) && !gameover)
			SwitchDirection();
	}

	void SwitchDirection(){
		if (rb.velocity.z > 0){
			rb.velocity = new Vector3(speed,0,0);
		}
		else if(rb.velocity.x > 0){
			rb.velocity = new Vector3(0,0,speed);
		}
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Diamond"){
			GameObject part = Instantiate (particle, col.gameObject.transform.position,Quaternion.identity) as GameObject;
			Destroy (col.gameObject);
			Destroy (part,1f);

		}
	}
}
