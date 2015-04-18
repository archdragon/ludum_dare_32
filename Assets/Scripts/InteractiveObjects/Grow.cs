using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {
	public float finalSizeY = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Call() {
		Vector3 newScale = transform.localScale;
		newScale.y = Mathf.Lerp(transform.localScale.y, finalSizeY, 0.05f);
		transform.localScale = newScale;
	}
}
