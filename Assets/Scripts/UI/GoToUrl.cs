using UnityEngine;
using System.Collections;

public class GoToUrl : MonoBehaviour {

	// Use this for initialization
	public void Jump (string url) {
		Debug.Log("Opening: " + url);
		Application.OpenURL(url);
	}

	void OnMouseUp () {
		Jump ("http://google.com");
	}

}
