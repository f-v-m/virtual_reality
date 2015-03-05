using UnityEngine;
using System.Collections;

public class CameraMoving : MonoBehaviour {
	public Camera cameraFreeWalk;
	public float zoomSpeed = 20f;
	public float minZoomFOV = 10f;
	public float aspectRatio = 0.5625f;
	
	public void ZoomIn()
	{

		cameraFreeWalk.fieldOfView -= zoomSpeed/8;

		if (cameraFreeWalk.fieldOfView < minZoomFOV)
		{
			cameraFreeWalk.fieldOfView = minZoomFOV;
		}
	}
	
	public void PositionChange(float x, float y, float z){
		transform.position = new Vector3 (x, y, z);
	} 

	public void AnglesChange(float a, float b, float y){
		transform.rotation = Quaternion.Euler (a, b, y);
	}

	public void Start(){
		print (cameraFreeWalk.aspect);
		//cameraFreeWalk.aspect = aspectRatio;
	}

	public void Update(){
		ZoomIn ();
	}

}
