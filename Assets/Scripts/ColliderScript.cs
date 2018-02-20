using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag != "Enemy") {		
			DestroyObject (collision.gameObject);
		}
	}

}