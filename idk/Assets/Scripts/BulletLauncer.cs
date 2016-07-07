using UnityEngine;
using System.Collections;

public class BulletLauncer : MonoBehaviour {

	public GameObject bullet;

	void Update(){
		//Creates a bullet the the desired key is pressed.
		//Change 'Space' to any key you want. 
		if (Input.GetKeyDown (KeyCode.E)) {
			Instantiate (bullet, transform.position, transform.rotation);
		}
	}
}