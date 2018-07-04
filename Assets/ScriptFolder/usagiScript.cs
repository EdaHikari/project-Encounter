using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usagiScript : MonoBehaviour {

	Vector3 vec = new Vector3();
	CharacterController charaCon ;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		vec.x = Input.GetAxis("Horizontal");
		vec.z = Input.GetAxis("Vertical");

		Rigidbody rigidbody = GetComponent<Rigidbody>();
	}
}
