using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public static int currentHealth = 6;
    private int health = 6;
    public float reloadSpeed = 1.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetStats (){
        currentHealth = health;
    }
}
