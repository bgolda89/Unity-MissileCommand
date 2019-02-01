using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public KeyCode fireMissile;
    
    public Transform missileObject, targetPaint;
    public GameObject turretTip;

    private Vector2 mousePosition;
    public static Vector2 objPosition;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireMissile))
        {
            mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Instantiate(missileObject, turretTip.transform.position, turretTip.transform.rotation);
            Instantiate(targetPaint, objPosition, Quaternion.identity);
        }
	}
}
