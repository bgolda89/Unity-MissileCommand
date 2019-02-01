using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour {

    public float time = 0.5f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
