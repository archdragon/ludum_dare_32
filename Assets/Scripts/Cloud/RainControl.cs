using UnityEngine;
using System.Collections;

public class RainControl : MonoBehaviour {

	ParticleSystem particleSystem;

	// Use this for initialization
	void Start () {
		particleSystem = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.E)) {
			CastSphere();
		}
		if(Input.GetKeyDown(KeyCode.E)) {
			particleSystem.Play();
		} else if(Input.GetKeyUp(KeyCode.E)) {
			particleSystem.Stop();
		}
	}

	void CastSphere() {
		RaycastHit hit;
		if (Physics.SphereCast(transform.position, 1.0f, transform.TransformDirection(Vector3.down), out hit, 10)) {
			float distanceToObstacle = hit.distance;
			Grow grow = hit.transform.gameObject.GetComponent<Grow>();
			if(grow) {
				grow.Call();
			}
			Debug.Log("Spherecast distance: " + distanceToObstacle);
		}
	}
}
