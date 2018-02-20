using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	public float damage = 100f;

	public float getdamage(){
		return damage;
	}

	public void hit(){
		Destroy (gameObject);
	}
}
