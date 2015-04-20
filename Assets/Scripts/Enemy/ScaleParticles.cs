using UnityEngine;
using System.Collections;

public class ScaleParticles : MonoBehaviour {
	public float multiplier = 1.0f;
	void Update () {
		GetComponent<ParticleSystem>().startSize = transform.lossyScale.magnitude * multiplier;
	}
}
