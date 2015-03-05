using UnityEngine;
using System.Collections;

public class KhightInfo : MonoBehaviour {
	public string knightName;
	public int hitpoint;
	public int lvl;
	public int experience;
	public GameObject destroyEffect;

	public string Name {
		get {
			return name;
		}
		set {
			name = value;
		}
	}

	public int Hitpoint {
		get {
			return hitpoint;
		}
		set {
			hitpoint = value;
		}
	}

	public int Lvl {
		get {
			return lvl;
		}
		set {
			lvl = value;
		}
	}

	public int Experience {
		get {
			return experience;
		}
		set {
			experience = value;
		}
	}

	void Start(){
		Hitpoint = 100;
		Lvl = 0;
		Experience = 0;
	}

	void Update(){
		GameObject hp = GameObject.Find ("HitpointBar");
//		hp.GetComponent<UISlider> ().value = Hitpoint / 100f;
		GameObject label = GameObject.Find("Label");

		if (hitpoint <= 0) {
			hitpoint = 0;
			Instantiate(destroyEffect, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
//		label.GetComponent<UILabel> ().text = hitpoint.ToString () + "%";

	}
}
