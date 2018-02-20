using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunnerScript : MonoBehaviour {
	public float health=200f;
	public GameObject gun;
	public float currenthealth;
	public Slider healthslider;

	void Start(){
		currenthealth = health;
	}
	void OnTriggerEnter2D(Collider2D collider){
		BulletScript bullet = collider.gameObject.GetComponent<BulletScript> ();
		currenthealth -= 2;
		healthslider.value = currenthealth;

		if (bullet) {
			health -= bullet.getdamage ();
			bullet.hit ();
			//Handheld.Vibrate();

			if (currenthealth <= 0) {
				GetComponent<Animator> ().SetBool ("deadBool", true);
				GetComponent<Animator> ().SetTrigger ("deadTrigger");
				DestroyObject (gameObject, 3.0f);
				DestroyObject (gun, 0.2f);
			}

		}

	}
}
