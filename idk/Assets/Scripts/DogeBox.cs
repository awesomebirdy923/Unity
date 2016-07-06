using UnityEngine;
using System.Collections;

public class DogeBox : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void FixedUpdate(){
		gameObject.transform.Rotate (Vector3.up * speed);
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Player"){
			GameObject.Destroy (gameObject);
		}
	}
}
