using UnityEngine;
using System.Collections;

public class LoadInfoScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Activates when object is clicked
	void OnMouseDown(){
		Debug.Log("LOAD NEW SCREEN");

		Application.LoadLevel("GL-4000_screen");
	}
}
