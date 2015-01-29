using UnityEngine; 
using System.Collections; 
public class ChangeTexture : MonoBehaviour{ 

	public Texture TextureOver;
	public Texture TextureInit;
	public Transform bulletPrefab;
	public Transform target;
	
	void OnMouseExit(){
		renderer.material.mainTexture = TextureOver; 
	}

	void OnMouseOver(){ 
		renderer.material.mainTexture = TextureInit; 
	}
	void Update(){
		transform.LookAt (target);


	}
/*	void OnMouseDown() {
		RaycastHit hit;
		//Ray ray = Camera.main.ScreenPointToRay(transform.position);//задається напрямок
		Ray ray = new Ray (Camera.main.transform.position, -transform.forward);
		if (Physics.Raycast(ray, out hit, 20)){
			Fire(hit.point);
		}
	}
*/	
//	void Fire(Vector3 way){
	void OnMouseDown(){
		Rigidbody bullet;
		Transform go;
		go = (Transform)Instantiate(bulletPrefab, Camera.main.transform.position, transform.rotation);
		bullet = go.gameObject.AddComponent<Rigidbody>();
		bullet.mass = 2f;
		bullet.AddForce (-transform.forward*2500);
		//bullet.transform.Rotate(Vector3.down * Time.deltaTime, Space.World);
	}
	
} 
