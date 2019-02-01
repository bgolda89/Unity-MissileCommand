using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 0.5f);
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket")){
            Destroy(gameObject);
        }
    }


}
