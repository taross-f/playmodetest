using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("test");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(0, 0.01f, 0);
	}
}
