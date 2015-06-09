using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

	public string movieName;

	void Start (){
	
	}

	public void PlayM (){
		Handheld.PlayFullScreenMovie (movieName, Color.black, FullScreenMovieControlMode.CancelOnInput, FullScreenMovieScalingMode.AspectFit);
	}
}
