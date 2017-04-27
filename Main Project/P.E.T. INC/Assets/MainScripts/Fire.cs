using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	public GameObject firePrefab;
	float rate = 10;
	private float timeSinceLastSpawn = 0;

	// Update is called once per frame
	void Update () {
		timeSinceLastSpawn += Time.deltaTime;
		float correctTimeBetweenSpawns = 1f / rate;

		while (timeSinceLastSpawn > correctTimeBetweenSpawns){
			//Time to spawn a particle
			Instantiate(firePrefab , this.transform.position + Vector3.right, Quaternion.identity, this.transform);
			timeSinceLastSpawn -= correctTimeBetweenSpawns;
		}
	}

	void SpawnFireAlongOutline(){
		PolygonCollider2D col = GetComponent<PolygonCollider2D> ();
		int pathIndex = Random.Range (0, col.pathCount);
		Vector2[] points = col.GetPath (pathIndex);
		Vector2 spawnPoint = points [Random.Range (0, points.Length)];
		SpawnFireAtPosition (spawnPoint);
	}

	void SpawnFireAtPosition(Vector2 position){
		Instantiate(firePrefab ,position, Quaternion.identity, this.transform);
	}
}
