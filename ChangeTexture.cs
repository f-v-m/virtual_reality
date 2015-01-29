using UnityEngine; 
using System.Collections; 
public class ChangeTexture : MonoBehaviour{ 

	public Texture TextureOver;
	public Texture TextureInit;
	public Transform bulletPrefab;
	public Transform target;
	private bool mouseOn;

	public bool MouseOn {
		get {
			return mouseOn;
		}
		set {
			mouseOn = value;
		}
	}
	
	void OnMouseExit(){
		renderer.material.mainTexture = TextureOver; 
		mouseOn = false;
	}

	void OnMouseOver(){ 
		renderer.material.mainTexture = TextureInit; 
		mouseOn = true;
	}


} 
