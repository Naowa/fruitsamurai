using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour {

	public List<GameObject> fruits;
	public Transform fireLocation;

	// Force Parameters

	public float directionZ;
	public float directionY;


	public float interpolationPeriod;

	float time = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;

		if (time >= interpolationPeriod) {
			time = 0.0f;

			FireRandom();
		
		}

	}
	


	public void FireRandom () {
		int index = Random.Range(0, fruits.Count);

		GameObject fruit = fruits[index];

		FireFruit(fruit);

	}

	public void FireFruit (GameObject fruit) {
		Debug.Log("Fire!");

		GameObject spawnedFruit = Instantiate(fruit, fireLocation);

		Rigidbody fruitRb = spawnedFruit.GetComponent<Rigidbody>();

		Vector3 forceVector = new Vector3(0, directionY, directionZ);

		fruitRb.AddForce(forceVector, ForceMode.VelocityChange);
	}
}
