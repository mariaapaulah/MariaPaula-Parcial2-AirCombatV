using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	public float speed; 
	void Start () {



	}


	// Update is called once per frame
	void Update () {
		this.transform.Rotate (0, speed, 0);
	}
}
