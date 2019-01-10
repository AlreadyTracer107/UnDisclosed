using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour {
	public GameObject slime;

	// Use this for initialization
	void Start () {
		newRandomLocation();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void newRandomLocation(){
		var newX= slime.GetComponent<Transform>();
		print(newX.localPosition.x);
	}
}
