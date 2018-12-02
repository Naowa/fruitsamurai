using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour {

	public bool testing;
	public List<GameObject> fruits;
	public Transform fireLocation;
	public AudioSource cannonSound;

	// Force Parameters

	public float directionZ;
	public float directionY = 0.0f; // Kept in for sake of modularity. There should be no more reason to edit this.


	public float interpolationPeriod;

	float time = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (testing) {
			time += Time.deltaTime;

				if (time >= interpolationPeriod) {
					time = 0.0f;

					FireRandom();
				}
		
		
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
		cannonSound.Play();

		Rigidbody fruitRb = spawnedFruit.GetComponent<Rigidbody>();

		Vector3 forceVector = new Vector3(0, directionY, directionZ);

		fruitRb.AddRelativeForce(forceVector, ForceMode.VelocityChange); // Relative Force enables fruit to be fired in exact direction of
	}
}
