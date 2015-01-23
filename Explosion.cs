using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {
	public float explosionTime= 0.5f;
	void  Start (){
		Destroy (gameObject, explosionTime);
	}
}
