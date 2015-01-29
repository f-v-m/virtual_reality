using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {
	
	public GameObject explosionEffect;

	void OnClick(){
//		GameObject knight = GameObject.Find ("Knight");
		GameObject player = GameObject.Find ("MainPlayer");
		player.GetComponent<PlayerAction> ().Mode = true;
		player.GetComponent<PlayerAction> ().ExplosionEffect = explosionEffect;

	}

	void ChangeMode(){

	}


	
}
