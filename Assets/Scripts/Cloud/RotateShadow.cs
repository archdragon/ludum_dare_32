using UnityEngine;
using System.Collections;

public class RotateShadow : MonoBehaviour {
	public float rotationX = 0.0f;
	public float rotationY = 0.0f;
	public float rotationZ = 0.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f));
	}
}
