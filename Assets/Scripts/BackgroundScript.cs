using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour {
	public float speed = 0.2f;

	void Start () {
		
	}
	

	void Update () {
		transform.Translate (Vector3.left * speed * Time.deltaTime);
		
	}
}
