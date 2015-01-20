using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour
{
	
	public MeshRenderer[] UseWebcamTexture;
	private WebCamTexture webcamTexture;
	
	void Start()
	{
		webcamTexture = new WebCamTexture();
		foreach(MeshRenderer r in UseWebcamTexture)
		{
			r.material.mainTexture = webcamTexture;
		}
		renderer.material.mainTexture = webcamTexture;
		webcamTexture.Play();
	}

}
