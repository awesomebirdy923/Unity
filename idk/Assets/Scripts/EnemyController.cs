using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject player;
	public float moveSpeed;

	// Update is called once per frame
	void FixedUpdate () {
		//This will move the object toward the player GameObject
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
	}
//	void onTriggerEnter(Collider c){
//		if(c.gameObject.tag == "Player"){
//			Destroy (gameObject);
//			Destroy (this);
//		}
//	}
} 