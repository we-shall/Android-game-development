using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

	public GameObject obj;
	public GameObject diamond;
	float size;
	Vector3 lastpos;
	public bool gameover;
	// Use this for initialization
	void Start () {
		gameover = false;
		lastpos = obj.transform.position;
		size = obj.transform.localScale.x;

		// for(int i = 0; i < 200; i ++)
		// 	SpawningRandomly();

		InvokeRepeating("SpawningRandomly",2.0f,0.2f);

	}
	
	// Update is called once per frame
	void Update () {
		if (gameover){ CancelInvoke("SpawningRandomly"); }
		
	}

	void SpawningRandomly(){

		int rand = Random.Range(0,6);
		if (rand < 3){
			SpawnX();
			}
		else if (rand >= 3)
			SpawnZ();
		
	}	

	void SpawnX(){

		Vector3 pos = lastpos;
		pos.x += size;
		lastpos = pos;
		Instantiate(obj,pos,Quaternion.identity);

		int rand = Random.Range(0,4);
		if (rand == 0)
			Instantiate(diamond,new Vector3(pos.x,pos.y+1,pos.z),diamond.transform.rotation);



	}

	void SpawnZ(){

		Vector3 pos = lastpos;
		pos.z += size;
		lastpos = pos;
		Instantiate(obj,pos,Quaternion.identity);

		int rand = Random.Range(0,4);
		if (rand == 0)
			Instantiate(diamond,new Vector3(pos.x,pos.y+1,pos.z),diamond.transform.rotation);

	}
}
