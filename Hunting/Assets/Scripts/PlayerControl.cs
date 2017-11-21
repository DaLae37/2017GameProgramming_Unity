using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
    int runSpeed = 2;
    int rotSpeed = 3;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.LeftShift))
            runSpeed = 5;
        else
            runSpeed = 2;
        transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * runSpeed);
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * rotSpeed);
	}
}
