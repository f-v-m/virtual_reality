using UnityEngine;
using System.Collections;


// Universal Video Texture Lite Ver. 1.1

public class V2Ttest : MonoBehaviour 
{
	public float FPS = 30;
	
	public int firstFrame;
	public int lastFrame;
	
	public string FileName = "VidTex";
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
			
			if (DigitsLocation == digitsLocation.Postfix){
				Destroy(newTex);
				//newTex = Resources.Load(FileName + indexStr) as Texture;
				string uri = "file:///Users/f_v_m/Downloads/SnowLeopard_Lion_Mountain_Lion_Mavericks_19.01.2015/images/"+FileName + indexStr + ".png";
				//string uri = "http://192.168.0.134/images/"+FileName + indexStr + ".png";
				//print (uri);
				WWW www = new WWW(uri);
				
				newTex = www.texture as Texture;
				
			}
			else {
				newTex = Resources.Load(indexStr + FileName) as Texture;
			}
			renderer.material.mainTexture = newTex;
			lastIndex = intIndex;
		}
		
		
		
		
	}
	
/*	void OnGUI()
	{
		if (enableReplay && showInstructions)
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height),"Click the left mouse button or touch the screen to rewind & replay");
		if (intIndex <= lastFrame)
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height),newTex,ScaleMode.ScaleToFit,true,aspectRatio); // Actual video texture draw
		
	}*/
}

// Class for audio management

