using UnityEngine;
using System.Collections;


public class hz : MonoBehaviour {
	public WWW wwwData1;
	public WWW wwwData2;
	public WWW wwwData3;
	public string[] url;
	
	MovieTexture movie1;
	MovieTexture movie2;
	MovieTexture movie3;

	float time = 0.0f;
	int tmp;
	//public Texture2D st;
	void Start () {
		tmp = 0;
		//guiTexture.texture = st;
		
		wwwData1 = new WWW(url[0]);
		wwwData2 = new WWW(url[1]);
		wwwData3 = new WWW(url[2]);
		movie1 = wwwData1.movie;
		movie2 = wwwData2.movie;
		movie3 = wwwData3.movie;
		while (!movie1.isReadyToPlay) {
		}
		
		
		renderer.material.mainTexture = movie1;
		movie1.Play ();
		
	}
	

	
	void Update(){
		time += Time.deltaTime;
		
		if (4.9f <= time && time <= 5.1f) {
			if (tmp == 2) {
				tmp = 0;	
			} else {
				tmp +=1;	
			}
			//Destroy(movie);
//			Script(url[tmp]);
			if (tmp == 0){
				renderer.material.mainTexture = movie1;
				movie3.Stop();
				movie1.Play ();
			} else if (tmp == 1){
				renderer.material.mainTexture = movie2;
				movie1.Stop();
				movie2.Play ();
			} else if (tmp == 2){
				renderer.material.mainTexture = movie3;
				movie2.Stop();
				movie3.Play ();

			} 
			time = 0.0f;
			
		}
		
		
	}

}