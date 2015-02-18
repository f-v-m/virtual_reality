using UnityEngine;
using System.Collections;

public class BrowserGUI : MonoBehaviour {
	GameObject[] effectList;
	string[] effectListNames;
	int r;
	GameObject knight;

	public GameObject Knight {
		get {
			return knight;
		}
		set {
			knight = value;
		}
	}

	void Start(){
		//
		effectList = Camera.main.GetComponent<PlayerAction> ().effectList;
		effectListNames = new string[effectList.Length];
		//effectlist names:
		for (int i = 0; i<effectList.Length; i++) {
			effectListNames [i] = effectList [i].name;
		}
		//send effectList to Browser:

	}
	

	public void Action(string knightName, string effect){

		knight = GameObject.Find (knightName);
		if (effect == effectListNames[0]) {
			gameObject.GetComponent<PlayerAction> ().Mode = true;
			gameObject.GetComponent<PlayerAction> ().ExplosionEffect = effectList[0];
		}
		if (effect == effectListNames[1]) {
			gameObject.GetComponent<PlayerAction> ().Mode = true;
			gameObject.GetComponent<PlayerAction> ().ExplosionEffect = effectList[1];
		}
	}

	public void GetEffectList(string func){
		Application.ExternalCall ("exportedSetEffectsList", effectListNames);
	}

	public void KnightID(string name){
		knight = GameObject.Find (name);

	}




}

