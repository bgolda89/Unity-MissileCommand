using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileControl : MonoBehaviour {
    Vector3 targetPosition, startPosition;
    public Transform boom, boomCollider;
    bool collided = false;

    private LineRenderer laserLine;

    public float time = 2f;
    private void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
        laserLine.SetPosition(0, transform.position);
        laserLine.SetPosition(1, transform.position);
        
    }
    void Start () {
        startPosition = transform.position;
        targetPosition = PlayerController.objPosition;
        StartCoroutine(GoToTarget());
	}
	
	// Update is called once per frame
	void Update () {
        laserLine.SetPosition(1, transform.position);
	}

    IEnumerator GoToTarget()
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0 && !collided)
        {
            i += Time.deltaTime * rate;
            transform.position = Vector3.Lerp(startPosition, targetPosition, i);
            yield return null;
        }
        this.Detonate();
    }

    private void Detonate() {
        Destroy(gameObject);
        Instantiate(boom, transform.position, boom.transform.rotation);
        Instantiate(boomCollider, transform.position, boomCollider.transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")){
            collision.gameObject.GetComponent<EnemyCol>().Detonate();
            collided = true;
            Detonate();
        }
    }
}
