using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandling : MonoBehaviour {

	public Transform fruitTransform;
	public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Smush () {
		fruitTransform.localScale -= new Vector3(0, 0.8f, 0);
	}

	void Slice () {
		Destroy(gameObject);
	}
}
