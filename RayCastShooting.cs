using UnityEngine;
using System.Collections;

public class RayCastShooting : MonoBehaviour {
	public Transform bulletPrefab;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);//задається напрямок
			//if (Physics.Raycast(transform.position, Direction, out hit, 1000)){//1000 - відстань променю
			if (Physics.Raycast(ray, out hit, 20)){
				Fire(hit.point);
			}
		}
	
	}

	void Fire(Vector3 way){
		Rigidbody bullet;
		Transform go;
		go = (Transform)Instantiate(bulletPrefab, gameObject.transform.position, Quaternion.identity);
		bullet = go.gameObject.AddComponent<Rigidbody>();
		bullet.mass = 2f;
		bullet.AddForce (way*200);
	}

}
