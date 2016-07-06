using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour {

	public string nextLevel;


	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.S)){
			Debug.Log ("test");
			SceneManager.LoadScene(0);
		}
	}
}
