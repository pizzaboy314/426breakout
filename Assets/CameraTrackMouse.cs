using UnityEngine;
using System.Collections;

public class CameraTrackMouse : MonoBehaviour {
	
	public float amount = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Mouse Y")*amount*Time.deltaTime;
		float v = Input.GetAxis("Mouse X")*amount*Time.deltaTime;
		
		transform.Rotate(h,v,0);
	}
}
