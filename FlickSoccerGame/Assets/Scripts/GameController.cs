using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization


	[SerializeField]
	GameObject ballPrefabs;
	GameObject ballInstance;
	[SerializeField]
	float ballforce;

	Vector3 start;
	Vector3 end;
	float minDragDistance = 15.0f;
	float zDepth = 25f;

	void Awake (){

	}
	void Start () {
		CreateBall();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
			{
				start = Input.mousePosition;
			}
		if (Input.GetMouseButtonUp(0))
			{
				end = Input.mousePosition;

				if (Vector3.Distance (start,end) > minDragDistance)
				{
					Vector3 hitposition = new Vector3 (Input.mousePosition.x,Input.mousePosition.y,zDepth);
					hitposition =  Camera.main.ScreenToWorldPoint(hitposition);
					ballInstance.transform.LookAt(hitposition);

					ballInstance.GetComponent <Rigidbody>().AddRelativeForce(Vector3.forward*ballforce,ForceMode.Impulse);
					Invoke ("CreateBall",2f);
				}
			}

		
	}

	void CreateBall (){
		ballInstance = Instantiate (ballPrefabs,ballPrefabs.transform.position,Quaternion.identity) as GameObject;
	}
}
