using UnityEngine;

public class test: MonoBehaviour {
	public Transform Cannonball;
	int fullCountBall = 0;
	
	
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitt;
			if (Physics.Raycast(ray, out hitt, 1000))
			{
				Fire(hitt.point);
			}
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Fire(transform.forward);
		}
	}
	
/*	void OnGUI()
	{
		GUI.Label(new Rect(0, 0, 200, 50), &quot;COUNT: &quot; + fullCountBall.ToString());
	}
*/	
	void Fire(Vector3 way)
	{
		Transform go = (Transform)Instantiate(Cannonball, gameObject.transform.position,Quaternion.identity);
		Rigidbody rb = go.gameObject.AddComponent<Rigidbody>();
		rb.mass = 1.5f;
		rb.AddForce(transform.forward*2500);
		fullCountBall++;
	}
}