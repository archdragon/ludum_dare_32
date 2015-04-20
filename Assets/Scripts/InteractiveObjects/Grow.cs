using UnityEngine;
using System.Collections;

public class Grow : MonoBehaviour {
	public float finalSizeX = 1.0f;
	public float finalSizeY = 1.0f;
	public float finalSizeZ = 1.0f;
	private float finalPosition;
	private Vector3 finalScale;
	public float positionOffsetY = 0.0f;
	public float lerpStep = 0.05f;

	public bool bounceBack = false;
	public float bounceBackTime = 4.0f;

	private float bounceBackTimer = 0.0f;
	private bool isBouncingBack = false;

	private Vector3 originalScale;
	private float errorTolerance = 0.03f;
	private float scaleDistance = 0.0f;


	// Use this for initialization
	void Start () {
		originalScale = transform.localScale;
		finalScale = new Vector3(finalSizeX, finalSizeY, finalSizeZ);
		finalPosition = transform.position.y + positionOffsetY;
	}
	
	// Update is called once per frame
	void Update () {
		if(bounceBack) {
			scaleDistance = Vector3.Distance(originalScale, transform.localScale);
			if(isBouncingBack) {
				RescaleTo(originalScale);
				if(scaleDistance < errorTolerance) {
					isBouncingBack = false;
					bounceBackTimer = 0.0f;
				}
			} else {
				if(scaleDistance > 10.0f * errorTolerance) {
					bounceBackTimer += Time.deltaTime;			
					if(bounceBackTimer >= bounceBackTime) {
						isBouncingBack = true;
					}
				}
			}
		}
	}

	public void Call() {
		RescaleTo(finalScale);

		Vector3 newPosition = transform.position;
		newPosition.y = Mathf.Lerp(transform.position.y, finalPosition, lerpStep);
		transform.position = newPosition;
		bounceBackTimer = 0.0f;
	}

	private void RescaleTo(Vector3 rescaleTo) {
		transform.localScale = Vector3.Lerp(transform.localScale, rescaleTo, lerpStep);
	}
}
