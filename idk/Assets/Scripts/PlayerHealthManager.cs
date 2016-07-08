using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

	public int health;

	// Use this for initializationß
	
	// Update is called once per frame
	void Update () {
		if(health <= 0){
			Destroy (gameObject);
			Destroy (this);
		}
	}

	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag == "Enemy"){
			health--;
		}
	}
}
