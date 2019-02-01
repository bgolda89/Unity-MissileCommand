using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public float RotationSmoothingCoef = 0.01f;

    public GameObject turret;

    //private Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void FixedUpdate()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Quaternion rot = Quaternion.LookRotation(mousePosition - turret.transform.position, turret.transform.TransformDirection(Vector3.forward));
        turret.transform.rotation = new Quaternion(0, 0, rot.z, rot.w);
    }
}
