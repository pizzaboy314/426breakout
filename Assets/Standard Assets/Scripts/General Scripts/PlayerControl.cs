using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	float speed = 1f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(speed.ToString());

		float x = Input.GetAxis("Horizontal");

		Vector3 vec = new Vector3(x,0,0);
		transform.Translate(vec * speed);

		if(gameObject.transform.position.x < -5.310218){
			transform.position = (new Vector3(-5.310218f,0.3087361f,-2.683758f) * speed);
			//gameObject.transform.position.x = 5.310218;
		}
		if(gameObject.transform.position.x > 6.16233){
			transform.position = (new Vector3(6.16233f,0.3087361f,-2.683758f) * speed);
			//gameObject.transform.position.x = 6.16233;
		}
	}
	void OnCollisionEnter(Collision collision ){
		GameObject obj = collision.gameObject;
		if(obj.transform.name.Equals("Ball")){
			audio.Play();
		}				
	}
}
