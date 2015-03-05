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
	public Transform infoPrefab;
	GameObject info;
	bool t;
	public Vector3 creatingPlace;
	//Effects list
	public GameObject[] effectList;
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
		t = false;
		string[] effectList;



	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Knight")) {
						if (mode == true) {
								if (knight.GetComponent<ChangeTexture> ().MouseOn) {
										if (Input.GetMouseButtonDown (0)) {
												Application.ExternalCall ("exportedKnightInfo", knight.GetComponent<KhightInfo> ().knightName, knight.GetComponent<KhightInfo>().Hitpoint);
												go = (Transform)Instantiate (bulletPrefab, Camera.main.transform.position, Camera.main.transform.rotation);
												bullet = go.gameObject.AddComponent<Rigidbody> ();
												bullet.mass = 2f;
												//Calculating of direction of bullet:
												Vector3 vector = knight.transform.position - bullet.transform.position;

												bullet.AddForce (vector * 600);
										}
								}
						} else {
								if (knight.GetComponent<ChangeTexture> ().MouseOn) {
										if (Input.GetMouseButtonDown (0)) {
												if (!t) {
														//Vector3 tmp = new Vector3 (knight.transform.position.x + 1f, knight.transform.position.y + 1f, knight.transform.position.z);

														//info = (GameObject)Instantiate (infoPrefab, tmp, knight.transform.rotation);
//							info = (GameObject) Instantiate (infoPrefab) as GameObject;//, creatingPlace, Quaternion.identity);
														//info.transform.position = new Vector3 (knight.transform.position.x + 1f, knight.transform.position.y + 1f, knight.transform.position.z);

														t = true;
												} else {
														Destroy (info);
														t = false;
												}
										}
								}
						}

						if (t) {
								//info.transform.position = new Vector3 (knight.transform.position.x + 1f, knight.transform.position.y + 1f, knight.transform.position.z);
						}


				}
	}



}
