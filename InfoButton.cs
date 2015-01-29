using UnityEngine;
using System.Collections;

public class InfoButton : MonoBehaviour {
	
	public GameObject explosionEffect;
	
	void OnClick(){
//		GameObject knight = GameObject.Find ("Knight");
		GameObject player = GameObject.Find ("MainPlayer");
		player.GetComponent<PlayerAction> ().Mode = false;

		
	}
	
	void ChangeMode(){
		
	}
	
	
	
}