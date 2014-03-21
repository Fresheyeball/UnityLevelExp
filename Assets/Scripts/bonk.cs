using UnityEngine;
using System.Collections;

public class bonk : MonoBehaviour {
	
	void OnCollisionEnter(Collision collision){
		if (collision.relativeVelocity.magnitude > 2) {
			audio.Play();
		}
	}
}
