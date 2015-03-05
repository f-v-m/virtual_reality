using UnityEngine;
using System.Collections;

public class VoteButton : MonoBehaviour {
	public GameObject prefab;
	GameObject obj;

	void OnClick(){
		obj = (GameObject)Instantiate (prefab);
	}


}
