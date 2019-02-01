using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionCollider : MonoBehaviour {
    private CircleCollider2D circleCollider;
    public float swellMultiplier = 2.0f;
    public float explosionTime = 1.0f;

    private void Awake()
    {
        circleCollider = GetComponentInChildren<CircleCollider2D>();
        Destroy(gameObject, explosionTime);
    }

    // Update is called once per frame
    void Update () {
        circleCollider.radius += Time.deltaTime * swellMultiplier;
    }
}
