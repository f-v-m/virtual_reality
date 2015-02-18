using UnityEngine;
using System.Collections;

public class PrebafMoving : MonoBehaviour {
	GameObject obj;


	
	// Use this for initialization
	void Start()
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		if (GameObject.Find("Knight")){

		obj = GameObject.Find ("Knight");
		if (GameObject.Find ("CrowStorm_Main")) {
			GameObject fly = GameObject.Find ("CrowStorm_Main");
			fly.transform.position = new Vector3 (obj.transform.position.x, obj.transform.position.y+2f, obj.transform.position.z);
		}

		Vector3 ttt = new Vector3 (obj.transform.position.x, obj.transform.position.y-1f, obj.transform.position.z);
		Particle[] particles = particleEmitter.particles;
//		print (particles.Length);
		for (int i = 0; i < particles.Length; i++)
		{
			particles[i].position = ttt;
			//particles[i].position = new Vector3;
		}

		particleEmitter.particles = particles;

		}
	}
}