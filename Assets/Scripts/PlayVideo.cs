using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

	public string movieName;

	void Start (){
	
	}

	public void PlayM (){
        if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            Handheld.PlayFullScreenMovie(movieName, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFit);
        }
    }
}
