using UnityEngine;
using System.Collections;

public class BadaBoom : MonoBehaviour {
	public GameObject explosion; 
	public Quaternion rotation;
	public AudioClip BadaBoomAudio;
	
	void  OnCollisionEnter (  Collision collision   ){

		ContactPoint contact = collision.contacts[0];
		rotation= Quaternion.FromToRotation( Vector3.up, contact.normal ); 
		audio.PlayOneShot(BadaBoomAudio);
		Object instantiatedExplosion = Instantiate( explosion, contact.point, rotation );
		Destroy( gameObject );
	}﻿
}
