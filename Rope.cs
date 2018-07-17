using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour {

	void Start () {
		
	}
		void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			GetComponent<DistanceJoint2D> ().enabled = true;
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 500f);
			gameObject.transform.position= new Vector3 (transform.position.x,-1,transform.position.z);
			StartCoroutine (wait ());
		}
	}
	IEnumerator wait(){
		yield return new WaitForSeconds (3);
		GetComponent<DistanceJoint2D> ().enabled = false;

	
	}
}
