using UnityEngine; 
using System.Collections; 
public class ChangeTexture : MonoBehaviour{ 
	

	public Texture TextureOver;
	public Texture TextureInit;
	public GameObject bullet;
	public ParticleEmitter hz;

	void OnMouseExit(){
		renderer.material.mainTexture = TextureOver; 
	}

	void OnMouseOver(){ 
		renderer.material.mainTexture = TextureInit; 
		hz.emit=false;

	}

	void OnMouseUp(){
/*		float speed = 20;
		float step = speed * Time.deltaTime;
		GameObject newbullet = (GameObject)Instantiate( bullet, new Vector3(2f,1.5f,-1f), Quaternion.identity);
		//newbullet.transform.position = Vector3.MoveTowards (newbullet.transform.position, transform.position, step);
		newbullet.transform.position = Vector3.Lerp (new Vector3(2f,1.5f,-1f), transform.position, 1);
*/
//		hz.emit=false;
		//yield return new WaitForSeconds(2);
		//hz.emit=false;

	}

} 
