using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private Vector3 position;
    
    //public PlayerHealth playerHealth;       // Reference to the player's heatlh.
    public GameObject enemy;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.

	// Use this for initialization
	void Start () {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Spawn()
    {
        // If the player has no health left...
        //if (playerHealth.currentHealth <= 0f)
        //{
            // ... exit the function.
            //return;
        //}
        position = new Vector3(Random.Range(-10, 10), 7, 0);
        Instantiate(enemy, position, Quaternion.identity);

    }
}