using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public Transform bomb, jetTail;
    Vector3 targetPosition, startPosition;
    public float time;
    private LineRenderer laserLine;

    private bool canSplit = true;

    private float splitTimer; 
    private float enemyTimer = 0f;

    EnemyCol enemyCol;


	// Use this for initialization
	void Start () {
        enemyCol = GetComponentInChildren<EnemyCol>();
        canSplit = (Random.value > 0.5f);
        splitTimer = Random.Range(1f, 4.0f);
        startPosition = gameObject.transform.position;
        targetPosition = new Vector3(Random.Range(-7, 7), -6, 0);
        laserLine = GetComponent<LineRenderer>();
        laserLine.SetPosition(0, transform.position);
        laserLine.SetPosition(1, jetTail.position);
        Quaternion rot = Quaternion.LookRotation(startPosition - targetPosition, gameObject.transform.TransformDirection(Vector3.forward));
        gameObject.transform.rotation = new Quaternion(0, 0, rot.z, rot.w);
        StartCoroutine(GoToTarget());
	}
	
	// Update is called once per frame
	void Update () {
        laserLine.SetPosition(1, jetTail.position);
        enemyTimer += Time.deltaTime;

        if (enemyTimer > splitTimer && canSplit && gameObject.transform.position.y > 0){
            Split();
        }
	}

    private void Split() 
    {
        Instantiate(bomb, gameObject.transform.position, Quaternion.identity);
        canSplit = false;
    }

    IEnumerator GoToTarget()
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0)
        {
            i += Time.deltaTime * rate;
            transform.position = Vector3.Lerp(startPosition, targetPosition, i);
            yield return null;
        }
        enemyCol.Detonate();
    }
}
