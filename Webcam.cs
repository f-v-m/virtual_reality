using UnityEngine;
using System.Collections;

public class Webcam : MonoBehaviour
{
	
	public MeshRenderer[] UseWebcamTexture;
	public int WebcamChanger;
	private WebCamTexture webcamTexture;
	private string _SavePath = "/Users/f_v_m/";
	int _CaptureCounter = 0;
	public GameObject iconPrefab;
	float x = -5f;
	float y = 290f;
	float z = 0f;
	GameObject obj;
	GameObject objParent;

	void Start()
	{
		objParent = GameObject.Find ("Grid");
		WebCamDevice[] devices = WebCamTexture.devices;//список камер
		webcamTexture = new WebCamTexture();
		foreach(MeshRenderer r in UseWebcamTexture)
		{
			r.material.mainTexture = webcamTexture;
		}
		GetComponent<Renderer>().material.mainTexture = webcamTexture;
		//вибір камери 0 - вбудована, 1 - зовнішня
		webcamTexture.deviceName = devices[WebcamChanger].name;
		webcamTexture.Play();
	}

	void OnClick(){
		Texture2D snap = new Texture2D(webcamTexture.width, webcamTexture.height);
		snap.SetPixels(webcamTexture.GetPixels());
		
		snap.Apply();
		
		System.IO.File.WriteAllBytes(_SavePath + _CaptureCounter.ToString() + ".png", snap.EncodeToPNG());

		print ("!!");
		GameObject obj = GameObject.Find ("webcamshot(Clone)");
		Destroy (snap);

		//webcamTexture.Stop ();
		Destroy (obj);
		webcamTexture.Stop ();


		//створення картинки

		obj = (GameObject)Instantiate (iconPrefab);

		obj.transform.parent = objParent.transform;
		obj.transform.position = new Vector3 (-4, 353, 0);;
		string url = _SavePath + _CaptureCounter.ToString () + ".png";
		GameObject objCube = GameObject.Find ("Cube");
		WWW www = new WWW ("file://" + _SavePath + _CaptureCounter.ToString () + ".png");

		while (!www.isDone) {
				}
		objCube.GetComponent<Renderer>().material.mainTexture = www.texture as Texture;

		y -= 120f;
		++_CaptureCounter;
	}


}
