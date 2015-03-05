using UnityEngine;
using System.Collections;

public class BadaBoom : MonoBehaviour {

	public Quaternion rotation;
	//public AudioClip BadaBoomAudio;
	//public GameObject explosionEffect;
	//public GameObject flying_effect;
	GameObject instantiatedExplosion;
	//GameObject bulletEffect;
	AudioClip sound;
	int hp;

	void  OnCollisionEnter (  Collision collision   ){

		ContactPoint contact = collision.contacts[0];

		GameObject knight = collision.gameObject;
		rotation = Quaternion.Euler (0f, 0f, 0f);
		instantiatedExplosion = Instantiate( Camera.main.GetComponent<PlayerAction>().ExplosionEffect, contact.point, rotation ) as GameObject;
		GetComponent<AudioSource>().PlayOneShot (sound);
		//GameObject knight = GameObject.Find("Knight");
		//deal damage:
		if (Camera.main.GetComponent<PlayerAction>().ExplosionEffect.name == "CrowstormEffect") {
			print (instantiatedExplosion.name);

			knight.GetComponent<KhightInfo>().Hitpoint -= 10;

		}

		if (Camera.main.GetComponent<PlayerAction>().ExplosionEffect.name == "FlashbangEffect") {
			print (instantiatedExplosion.name);

			knight.GetComponent<KhightInfo>().Hitpoint -= 5;
		}

		//Application.ExternalCall ("knightInfo", knight.GetComponent<KhightInfo> ().knightName, knight.GetComponent<KhightInfo>().Hitpoint);

		Destroy( gameObject );

	}﻿

	
}
