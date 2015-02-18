using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]
public class VideoToTexture : MonoBehaviour
{

	//public string uri = "http://192.168.0.134/output.ogg";
	public string uri = @"file:///Users/f_v_m/Downloads/SnowLeopard_Lion_Mountain_Lion_Mavericks_19.01.2015/sample.ogg";
	MovieTexture movieTexture;
	WWW www;



	void Start(){
	
		www = new WWW (uri);

		while (!www.movie.isReadyToPlay)
		{

		}
	
		movieTexture = www.movie;
//		print (movieTexture.duration);

		
		renderer.material.mainTexture = movieTexture;

		audio.clip = movieTexture.audioClip;
		//AudioClip audioClip = movieTexture.audioClip;
		movieTexture.Play ();
		audio.Play ();


	}


	void Update(){

	}

}

