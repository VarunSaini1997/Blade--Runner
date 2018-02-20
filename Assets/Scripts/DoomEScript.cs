using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomEScript : MonoBehaviour {
	public float walkspeed=4f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * walkspeed * Time.deltaTime);
	}
}
/*	float probability = Time.deltaTime * shootPerSecond;
		if (Random.value < probability) {
			attack ();
		}
	}


/*	void attack(){
		Vector3 startPosition = transform.position + new Vector3 (0, -1, 0);
		GameObject bullet = Instantiate (enemyBullet, startPosition, Quaternion.identity) as GameObject;
		bullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, -enemybulletspeed);
	}*/
/*public float walkspeed;

[Tooltip("Average no. of seconds between Appearance")]
public float appearAfterSeconds;

// Use this for initialization
void Start () {

}

// Update is called once per frame
void Update () {
	transform.Translate (Vector3.left * walkspeed * Time.deltaTime);	
}*/

