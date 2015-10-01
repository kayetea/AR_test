using UnityEngine;
using System.Collections;

public class MediaButtonToggles : MonoBehaviour {

    public void ToggleVisibility(GameObject toggleObject)
    {
		Debug.Log ("enter toggle visibility");
        if (toggleObject.activeSelf)
        {
            Debug.Log("turn off");
            toggleObject.SetActive(false);
        }
        else if (!toggleObject.activeInHierarchy)
        {
            Debug.Log("turn on");
            toggleObject.SetActive(true);
        }
    }

    public void ToggleAnimation(GameObject toggleObject)
    {
		if(toggleObject.GetComponent<Animator>()){
	        if (toggleObject.GetComponent<Animator>().enabled)
	        {
	            Debug.Log("turn off");
	            toggleObject.GetComponent<Animator>().enabled = false;
	        }
	        else if (!toggleObject.GetComponent<Animator>().enabled)
	        {
	            Debug.Log("turn on");
	            toggleObject.GetComponent<Animator>().enabled = true;
	        }
		}

		else if(toggleObject.GetComponent<Animation>()){
			foreach (AnimationState state in toggleObject.GetComponent<Animation>()){
				//pauses animation at speed 0 and plays it again at speed 1
				if(state.speed > 0){
					//pause anim
					state.speed = 0;
				}
				else{
					//play anim
					state.speed = 1;
				}
			}
		}
    }
}