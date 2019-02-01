using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeBase : MonoBehaviour {
    public Transform boom;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Detonate();
        }
    }

    private void Detonate()
    {
        Instantiate(boom, gameObject.transform.position, boom.transform.rotation);
        PlayerStats.currentHealth -= 1;
        Destroy(gameObject);
    }
}
