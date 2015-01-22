using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	GameObject explosion; 
	public Quaternion rotation;
	
	void  OnCollisionEnter (  Collision collision   ){
		ContactPoint contact = collision.contacts[0];
		rotation= Quaternion.FromToRotation( Vector3.up, contact.normal ); 
		Object instantiatedExplosion = Instantiate( explosion, contact.point, rotation );
		Destroy( gameObject );
	}﻿
}