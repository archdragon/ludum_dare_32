using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {
	public GameObject target;
	public float height = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 finalPosition = target.transform.position;
		finalPosition.y = target.transform.position.y + height;
		transform.position =  Vector3.Lerp(transform.position, finalPosition, 0.01f);
	}
}
