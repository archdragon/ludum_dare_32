using UnityEngine;
using System.Collections;

public class EnableCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Screen.lockCursor = false;
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
