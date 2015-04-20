using UnityEngine;
using System.Collections;

public class ExitScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "Player") {
			Application.LoadLevel(1);
		}
	}
}
