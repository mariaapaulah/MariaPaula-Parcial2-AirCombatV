using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileFalling : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//Mover hacia adelante 
		this.transform.Translate(0.0f, 0.0f, 0.8f);
	}
	void OnCollisionEnter(Collision collision)  { 

		if (collision.collider.gameObject.tag == "Enemy") {

			//Cargamos  el prehab de la explosion
			GameObject explosion = GameObject.Instantiate (Resources.Load ("Prefabs/Misil") as GameObject); 

			//Muevo la explosion hacia la nave que fue impactada
			explosion.transform.position = collision.collider.gameObject.transform.position;

			//Destruimos el objeto impactado por el  misil
			Destroy(collision.collider.gameObject);

			//Destruimos el misil
			Destroy (this.gameObject);


		}
		if (collision.collider.gameObject.tag == "Allie") {
			//Destruimos el misil
			Destroy(this.gameObject);

			//Busco el gameobject Modelo3D dentro del gameObject Alien
			GameObject Sol = collision.collider.gameObject.transform.Find("Sol").gameObject;

			Sol.GetComponent<Light> ().color = new Color (0, 1, 0);



		}
	}
}
