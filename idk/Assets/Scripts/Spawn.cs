using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
	public int maxX, maxZ;
	public int currentX, currentZ;
	// Use this for initialization
	void Start () {

		 int randomX = Random.Range(0,maxX);
		int randomZ = Random.Range (0,maxZ);

		gameObject.transform.position = new Vector3(randomX,1,randomZ);

	}

}
