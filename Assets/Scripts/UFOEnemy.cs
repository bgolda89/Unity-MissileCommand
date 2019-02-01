using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOEnemy : MonoBehaviour {
    public Transform bomb;
    Vector3 targetPosition, startPosition;
    public float time;
    private float enemyTimer = 0f;
    private float bombTimer;
    EnemyCol enemyCol;

	void Start () {
        enemyCol = GetComponentInChildren<EnemyCol>();
        bombTimer = Random.Range(1f, 4.0f);
        startPosition = gameObject.transform.position;
        targetPosition = new Vector3(10, startPosition.y, 0);
        StartCoroutine(GoToTarget());
	}
	
	void Update () {
        enemyTimer += Time.deltaTime;

        if (enemyTimer > bombTimer)
        {
            Bomb();
            bombTimer = Random.Range(1f, 4.0f);
            enemyTimer = 0f;
        }
	}

    private void Bomb()
    {
        Instantiate(bomb, gameObject.transform.position, Quaternion.identity);
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
