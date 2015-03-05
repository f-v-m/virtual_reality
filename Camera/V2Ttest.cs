using UnityEngine;
using System.Collections;
using System;


// Universal Video Texture Lite Ver. 1.1

public class V2Ttest : MonoBehaviour 
{
	public float FPS = 30;
	
	public int firstFrame;
	public int lastFrame;
	
	public string FileName;
	public string digitsFormat = "0000";
	
	public enum digitsLocation {Prefix, Postfix};
	public digitsLocation DigitsLocation = digitsLocation.Postfix;
	
	public float aspectRatio = 1.78f;
	
	public bool enableAudio = false;
	
	public bool enableReplay = true;
	
	public bool showInstructions = true;
	
	bool audioAttached = false;
	
	bool firstPlay = true;
	
	string indexStr = "";
	
	Texture newTex;
	Texture lastTex;
	
	float index = 0;
	
	int intIndex = 0;
	int lastIndex = -1;
	WWW www;
	
	//AttachedAudio myAudio = new AttachedAudio(); // Creates an audio class for audio management 
	
	
	void Awake()
	{
		// Application.targetFrameRate = 60; (Optional for smoother scrubbing on capable systems)
		
		//audioAttached = GetComponent("AudioSource");
		
		// Zeros camera range - effectively blackens the screen
		
//		camera.farClipPlane = 0;
//		camera.nearClipPlane = 0;
	}
	
	void Start ()
	{	
		//час початку запису відео камерою
		WWW start = new WWW ("file:///Users/f_v_m/Downloads/start_time.txt");
		while (!start.isDone) {
				}
		print (start.text);
		FileName = start.text.Substring(0, 10);
		//Destroy (start);


		//поточний час
		var epoch = (DateTime.UtcNow - new DateTime (1970, 1, 1)).TotalSeconds;
		print ("current " + Math.Round(epoch));
		//затримка в фреймах
		int delay = 100;
		//обрахування номеру першого фрейму
		firstFrame = Convert.ToInt32((Math.Round(epoch) - double.Parse (FileName))*25 - delay);
		//firstFrame = 50;
		print ("ff " + firstFrame);
		index = firstFrame;

	}
	
	
	void Update () 
	{
		// Forces audio sync on first play (helpful for some devices)

		
		index += FPS * Time.deltaTime;
		
		intIndex = (int)index;
		
		if (index >= lastFrame)
			index = lastFrame;
		
		if (intIndex != lastIndex)	
		{
			
			indexStr = string.Format("{0:" + digitsFormat + "}", intIndex); 
			

				Destroy(newTex);

				string uri = "file:///Users/f_v_m/Downloads/images/"+FileName + "_" + indexStr + ".jpeg";

				

				WWW www = new WWW(uri);
				while(!www.isDone){}
				newTex = www.texture as Texture;
				
			

			GetComponent<Renderer>().material.mainTexture = newTex;
			lastIndex = intIndex;
		}
		



		//DateTime epochStart = new DateTime(1970, 1, 1, 8, 0, 0, System.DateTimeKind.Utc);
		//print (Math.Round(epoch));

	}
	

}