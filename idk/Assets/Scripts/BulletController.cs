using UnityEngine;
using System.Collections;

public class BulletController : MonoBehaviour {

	public float speed;
	public float timeToLive = 2;

	private float startTime;

	void Start(){
		startTime = Time.realtimeSinceStartup;
	}

	// Update is called once per frame
	void Update(){

		//this will delete the game object after a set amount of time
		if (Time.realtimeSinceStartup >= startTime + timeToLive) {
			Destroy (gameObject);
			Destroy (this);
		}
	}

	void FixedUpdate () {
		//this will shoot the projectile forward
		transform.Translate (Vector3.forward * speed);
	}
} 
