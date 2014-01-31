using UnityEngine;
using System.Collections;

public class BallBehavior : MonoBehaviour {
	float speed = 40f;	
	int collide = 1;
	int score = 0;
	int boxesLeft = 52;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {
		//GUIStyle style = new GUIStyle();
		//style.fontStyle = FontStyle.Bold;
		//style.fontSize = 50;
		GUI.Label(new Rect(10, 10, 100, 20), "SCORE: " + score);
		if(boxesLeft == 0){
			GUI.Label(new Rect(600, 10, 100, 20), "GAME OVER");
			Time.timeScale = 0;
		}
	}
	void OnCollisionEnter(Collision collision ){
		GameObject obj = collision.gameObject;
		if(obj.transform.name.Equals("Box")){
			Destroy(obj);
			audio.Play();
			boxesLeft--;
			score+=5;
		}

		if(obj.transform.name.Equals("NoZone")){
			score-=3;
		}
		if(obj.transform.name.Equals("Player")){
			System.Random rand = new System.Random();
			Vector3 vec;
			float push;

			if(gameObject.transform.position.x < obj.transform.position.x){
				vec = new Vector3(-100f,0,0);
				rigidbody.AddForce(vec);
			}
			if(gameObject.transform.position.x > obj.transform.position.x){
				vec = new Vector3(100f,0,0);
				rigidbody.AddForce(vec);
			}

			collide++;
			if(collide == 3){
				collide = 1;
				push = rand.Next(-50,50);
			} else {
				push = 0;
			}
			vec = new Vector3(push,10*speed,0);
			rigidbody.AddForce(vec);
		}

	}
}
