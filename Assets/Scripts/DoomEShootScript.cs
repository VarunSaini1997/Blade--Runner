using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomEShootScript : MonoBehaviour {

	public GameObject enemyBullet;
	public float health = 150f;
	public float enemybulletspeed = 5f;
	public float shootPerSecond = 1.8f;
	public int scoreValue = 300;

/*	private ScoreScript scoreScript;

	static AudioSource BulletImpact;

	void Start(){
		scoreScript = GameObject.Find ("Text").GetComponent<ScoreScript> ();
	}
*/
	void Update(){
		float probability = Time.deltaTime * shootPerSecond;
		//print ("Delta time=" + Time.deltaTime);
		if (Random.value < probability) {
			attack ();
		}

	}

	void attack(){
		Vector3 startPosition = transform.position + new Vector3 (-2, -0.5f, 0);
		GameObject bullet = Instantiate (enemyBullet, startPosition, Quaternion.identity) as GameObject;
		bullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-enemybulletspeed,0);
	}

	/*void OnTriggerEnter2D(Collider2D collider){
		BulletsScript bullet = collider.gameObject.GetComponent<BulletsScript> ();

		if (bullet) {
			health -= bullet.getdamage ();
			bullet.hit ();


			if (health <= 0) {
				Destroy (gameObject);
				scoreScript.calculateScore (scoreValue);


				//BulletImpact = GetComponent<AudioSource> ();
				//BulletImpact.Play ();
			}
		}

	}*/

}
