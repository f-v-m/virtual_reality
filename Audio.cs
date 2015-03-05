using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour {
	//AudioClip aud;
	string url = @"file:///Users/f_v_m/Downloads/SnowLeopard_Lion_Mountain_Lion_Mavericks_19.01.2015/sample.ogg";
	//string url = "http://streaming.radionomy.com/RadionoMiX";
	//string url = "http://127.0.0.1:1234";
	void Start() {
		WWW www = new WWW(url);
		//audio.clip = www.GetAudioClip(true, true, AudioType.OGGVORBIS);

		GetComponent<AudioSource>().clip = www.movie.audioClip;
		while (!GetComponent<AudioSource>().clip.isReadyToPlay) {
		}
		GetComponent<AudioSource>().Play ();
		print (url);

	}
	void Update() {
		//if (!audio.isPlaying && audio.clip.isReadyToPlay)
			//audio.Play();
	}
	
	
}


