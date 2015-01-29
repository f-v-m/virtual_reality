using UnityEngine;
using System.Collections;

public class BadaBoom : MonoBehaviour {

	public Quaternion rotation;
	//public AudioClip BadaBoomAudio;
	//public GameObject explosionEffect;
	//public GameObject flying_effect;
	GameObject instantiatedExplosion;
	//GameObject bulletEffect;
	


	void  OnCollisionEnter (  Collision collision   ){

		ContactPoint contact = collision.contacts[0];
 
		rotation = Quaternion.Euler (0f, 0f, 0f);
		instantiatedExplosion = Instantiate( Camera.main.GetComponent<PlayerAction>().ExplosionEffect, contact.point, rotation ) as GameObject;

		Destroy( gameObject );

	}﻿

	
}
