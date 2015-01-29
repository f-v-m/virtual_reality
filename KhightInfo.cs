using UnityEngine;
using System.Collections;

public class KhightInfo : MonoBehaviour {
	public string name;
	public int hitpoint;
	public int lvl;
	public int experience;

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

}
