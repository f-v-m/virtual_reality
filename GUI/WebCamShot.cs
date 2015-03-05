using UnityEngine; 
using System.Collections;

public class WebCamShot : MonoBehaviour { 
	public GameObject prefab;
	public int resWidth = 2550; 
	public int resHeight = 3300;
	WebCamTexture wtc;
	private bool takeHiResShot = false;
	int _CaptureCounter = 0;
	private string _SavePath = "/Users/f_v_m/";
	
	public static string ScreenShotName(int width, int height) {
		return string.Format("{0}/screenshots/screen_{1}x{2}_{3}.png", 
		                     Application.dataPath, 
		                     width, height, 
		                     System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss"));
	}
	
	public void TakeHiResShot() {
		takeHiResShot = true;
	}

	void Start(){
		wtc = new WebCamTexture();
		wtc.Play ();
	}


	void LateUpdate() {

		if (Input.GetKeyDown ("q")) {

		}

		takeHiResShot |= Input.GetKeyDown("k");
		if (takeHiResShot) {

			print ("1dwdaw");
			//wtc.Pause();

			Texture2D snap = new Texture2D(wtc.width, wtc.height);
			snap.SetPixels(wtc.GetPixels());

			snap.Apply();

			System.IO.File.WriteAllBytes(_SavePath + _CaptureCounter.ToString() + ".png", snap.EncodeToPNG());
			++_CaptureCounter;

			takeHiResShot = false;
		}

	}
}