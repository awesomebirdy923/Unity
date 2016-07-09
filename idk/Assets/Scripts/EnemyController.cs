using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public GameObject player;
	public float moveSpeed;
	public int health;
	public float radiusAmt;
//	private bool playing = false;

	private float radius;

	// Update is called once per frame
	void FixedUpdate () {
		//This will move the object toward the player GameObject
		transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
	}

	void Update(){
		radius = Vector3.Distance (transform.position, player.transform.position);
		if(health <= 0){
			Destroy (gameObject);
			Destroy (this);
		}if (radius <= radiusAmt) {
//			playing = true;
			AudioSource audio = GetComponent<AudioSource> ();
			if(!audio.isPlaying){
				audio.Play ();
			}
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