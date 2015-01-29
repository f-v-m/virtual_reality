using UnityEngine;
using System.Collections;

public class BadaBoom : MonoBehaviour {

	public Quaternion rotation;
	//public AudioClip BadaBoomAudio;
	public GameObject explosion;
	public GameObject flying_effect;
	GameObject instantiatedExplosion;
	GameObject bulletEffect;

	float tiltZ = Input.GetAxis ("Vertical") * (-90f);

	void  OnCollisionEnter (  Collision collision   ){
		//GameObject par = GameObject.Find ("Knight");
		ContactPoint contact = collision.contacts[0];
 
		rotation = Quaternion.Euler (0f, 0f, 0f);
		instantiatedExplosion = Instantiate( explosion, contact.point, rotation ) as GameObject;

		Destroy( gameObject );
		//Destroy (bulletEffect);
	}﻿

	
}
