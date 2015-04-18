using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour {
	public int rayLength = 10;
	// Marker that follows the ray's end
	public GameObject marker; 

	// Marker that stays on the ground after clicking
	public GameObject placedMarker;

	// Is moving marker visible?
	private bool isMarkerVisible = false;

	// Where to move the marker when we don't need it
	// Not very elegant, but I only have 24 more hours!
	private Vector3 hiddenMarkerPosition = new Vector3(0, -10, 0);

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = new Ray(transform.position,  transform.TransformDirection(Vector3.forward));
		RaycastHit hit;
		Debug.DrawRay(transform.position,  transform.TransformDirection(Vector3.forward)*rayLength, Color.green);
		if(Physics.Raycast (ray, out hit, rayLength)) {
			marker.transform.position = hit.point;
			isMarkerVisible = true;
			if(Input.GetButtonDown("Fire1")) {
				placedMarker.transform.position = hit.point;
				Debug.Log("Placing the marker!");
			}
		} else {
			isMarkerVisible = false;
			marker.transform.position = hiddenMarkerPosition;
		}


	}
}
