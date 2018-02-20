using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviourScript : MonoBehaviour {
	float angle;

	private Vector3 pos;

	//public GameObject bullet;
//	public float distance = 10;

	// Use this for initialization
	void Start () {
		pos = new Vector3 ();
	}
	
	// Update is called once per frame
	void Update () {
			pos = Input.mousePosition;
			pos.z = -(transform.position.x - Camera.main.transform.position.x);
			Vector3 objpos = Camera.main.ScreenToWorldPoint(pos);
			pos.x = Mathf.Clamp (pos.x, 15f, 20f) - objpos.x;
			pos.y = Mathf.Clamp (pos.y, -7f, 6f) - objpos.y;
		    angle = ((Mathf.Atan2 (pos.y, pos.x) * Mathf.Rad2Deg-50));
			//angle2 = angle * 3;
			//angle2 = angle/2;
		transform.rotation = Quaternion.Euler(0, 0, -angle);
	
	//GameObject projectile = (GameObject)Instantiate( bullet, pos, Quaternion.identity);
	}



}

