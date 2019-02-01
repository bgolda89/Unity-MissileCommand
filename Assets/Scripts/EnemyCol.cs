using UnityEngine;

public class EnemyCol : MonoBehaviour {
    public Transform boom, boomCollider;
    GM gM;


	// Use this for initialization
	void Awake () {
        gM = FindObjectOfType<GM>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Detonate()
    {
        Destroy(gameObject);
        Instantiate(boom, transform.position, boom.transform.rotation);
        Instantiate(boomCollider, transform.position, boomCollider.transform.rotation);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Rocket"))
        {
            gM.AddScore(100);
            Detonate();
        }
    }
}
