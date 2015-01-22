using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour
{
	
	public MeshRenderer[] UseWebcamTexture;
	private WebCamTexture webcamTexture;
	
	void Start()
	{
		WebCamDevice[] devices = WebCamTexture.devices;//список камер
		webcamTexture = new WebCamTexture();
		foreach(MeshRenderer r in UseWebcamTexture)
		{
			r.material.mainTexture = webcamTexture;
		}
		renderer.material.mainTexture = webcamTexture;
		//вибір камери 0 - вбудована, 1 - зовнішня
		webcamTexture.deviceName = devices[1].name;
		webcamTexture.Play();
	}

}
