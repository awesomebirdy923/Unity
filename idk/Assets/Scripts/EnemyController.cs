using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject player;
	public float moveSpeed;
	public int health;

	// Update is called once per frame
	void FixedUpdate () {
		//This will move the object toward the player GameObject
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
	}

	void Update(){
		if(health <= 0){
			Destroy (gameObject);
			Destroy (this);
		}
	}

	void OnTriggerEnter(Collider c){
		if(c.gameObject.tag == "Projectile"){
//			Destroy (gameObject);
//			Destroy (this);
			health--;
		}
	}
} 