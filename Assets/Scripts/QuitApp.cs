﻿/*------------------------------------------------------
Project: AR_test
Program: QuitApp.cs
Author: Katelyn Godfrey

Description: Close application when X button is pressed.

Updated: 05/28/2015 
------------------------------------------------------

ADDED TO ARCAMERA GAME OBJECT.

ON QUIT_BTN ON CLICK TELL IT TO TRIGGER QUITAPP.EXIT.

------------------------------------------------------*/

using UnityEngine;
using System.Collections;

public class QuitApp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void Exit() {
		Application.Quit(); 
	}

	public void GoBack(){
		Application.LoadLevel("Main_AR");
		Resources.UnloadUnusedAssets ();
	
	}
}
