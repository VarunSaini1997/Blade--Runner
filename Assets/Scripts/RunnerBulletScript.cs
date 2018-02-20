using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerBulletScript : MonoBehaviour {
	
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	//public GameObject gun;

	float speed = 10f;	
			
	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			shoot ();
		}
	}
		
	public void shoot(){
		Vector3 shootDirection;
		shootDirection = Input.mousePosition;
		shootDirection.z = 0.0f;
		shootDirection = Camera.main.ScreenToWorldPoint (shootDirection);
		shootDirection = shootDirection - transform.position;

		GameObject bullet = Instantiate (bulletPrefab, bulletSpawn.position,transform.rotation);
		bullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (shootDirection.x * speed, shootDirection.y * speed);
	}
}
