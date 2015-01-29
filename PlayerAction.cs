using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour {
	public Transform bulletPrefab;
	public bool mode = false; //false - info when OnClick; True - attack when OnClick
	public Vector3 objPosition;
	GameObject explosionEffect;
	//next 2 field - for bullet initiation
	Rigidbody bullet;
	Transform go;
	public GameObject knight;
//_______________________________________________Get/Set
	public bool Mode {
		get {
			return mode;
		}
		set {
			mode = value;
		}
	}

	public Rigidbody Bullet {
		get {
			return bullet;
		}
		set {
			bullet = value;
		}
	}

	public GameObject ExplosionEffect {
		get {
			return explosionEffect;
		}
		set {
			explosionEffect = value;
		}
	}

	public Vector3 ObjPosition {
		get {
			return objPosition;
		}
		set {
			objPosition = value;
		}
	}

//_______________________________________________
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//True mode. Atack when mouse click
		if (mode == true) {
			if (knight.GetComponent<ChangeTexture>().MouseOn){
				if (Input.GetMouseButtonDown(0)){
					go = (Transform)Instantiate(bulletPrefab, Camera.main.transform.position, Camera.main.transform.rotation);
					bullet = go.gameObject.AddComponent<Rigidbody>();
					bullet.mass = 2f;
					//Calculating of direction of bullet:
					Vector3 vector = knight.transform.position - bullet.transform.position;

					bullet.AddForce(vector*600);
				}
			}
		} else{
			if (knight.GetComponent<ChangeTexture>().MouseOn){
				if (Input.GetMouseButtonDown(0)){
;
				}
			}
		}
	}



}
