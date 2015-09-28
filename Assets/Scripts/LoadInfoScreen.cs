using UnityEngine;
using System.Collections;

public class LoadInfoScreen : MonoBehaviour {

    public string sceneName;

	// Activates when object is clicked
	void OnMouseDown(){
		Debug.Log("LOAD NEW SCREEN");

		Application.LoadLevel(sceneName);
		Resources.UnloadUnusedAssets ();
	}
}
