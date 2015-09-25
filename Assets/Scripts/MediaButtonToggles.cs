using UnityEngine;
using System.Collections;

public class MediaButtonToggles : MonoBehaviour {

    public void ToggleVisibility(GameObject toggleObject)
    {
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
}