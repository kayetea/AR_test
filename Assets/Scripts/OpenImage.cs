/*------------------------------------------------------
Project: AR_test
Program: OpenImage.cs
Author: Katelyn Godfrey

Description: 

Updated: 06/02/2015 
------------------------------------------------------

ADD TO PANEL. ASSIGN IMAGES AS NEEDED.

------------------------------------------------------*/

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OpenImage: MonoBehaviour{
	public GameObject panel;
	public Texture2D[] imageArray;
	private int currentImage = 0;
	public RawImage rawImage; 

	public float changeTime = 10.0f;
	public float timeSinceLast = 1.0f;

	void Start() {
		currentImage = 0;
		rawImage.texture = imageArray[currentImage]; 
		Debug.Log(currentImage);
	}

	void Update(){
		Debug.Log(currentImage);
		if(timeSinceLast > changeTime && currentImage < imageArray.Length)
		{
			rawImage.texture = imageArray[currentImage];
			timeSinceLast = 0.0f;
			currentImage++;
		}

		/*if(currentImage == imageArray.Length)
		{
			currentImage = 0;
		}*/

		Debug.Log("time = " + timeSinceLast);
		timeSinceLast +=Time.deltaTime;
	}

}


/*public class OpenImage : MonoBehaviour {
	
	public GameObject panel;
	public GameObject productImage01;
	public GameObject productImage02;

	private bool move = false;
	public float targetPosition;
	public float speed;

	void Update(){

		if(move)
		{
			Vector3 newPosition = transform.position;
			newPosition.x -= speed * Time.deltaTime;
			transform.position = newPosition;

			if(transform.position.x < targetPosition){
				move = false;
				Debug.Log ("STOP");
			}
		}
	}
	
	public void showImage01(){
		//make sure wrong image is closed, then open correct one
		productImage02.SetActive(false);
		panel.SetActive(true);
		productImage01.SetActive(true);

	}

	public void showImage02(){
		//make sure wrong image is closed, then open correct one
		productImage01.SetActive(false);
		panel.SetActive(true);
		productImage02.SetActive(true);
	
	}

	//CHECK SWIPES

	protected virtual void OnEnable()
	{
		// Hook into the OnSwipe event
		Lean.LeanTouch.OnFingerSwipe += OnFingerSwipe;
	}
	
	protected virtual void OnDisable()
	{
		// Unhook into the OnSwipe event
		Lean.LeanTouch.OnFingerSwipe -= OnFingerSwipe;
	}
	
	public void OnFingerSwipe(Lean.LeanFinger finger)
	{
		// Store the swipe delta in a temp variable
		var swipe = finger.SwipeDelta;
		
		if (swipe.x < -Mathf.Abs(swipe.y))
		{
			Debug.Log ("You swiped left!");

			move = true;
		}
		
		if (swipe.x > Mathf.Abs(swipe.y))
		{
			Debug.Log ("You swiped right!");

		}
	}
	
}*/