using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public Camera mainCam;
    private Transform myTr;
    private Transform camTr;
	// Use this for initialization
	void Start () {
        myTr = GetComponent<Transform>();
        camTr = mainCam.transform;

        myTr.transform.position = camTr.transform.position;
        myTr.transform.rotation = camTr.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        camTr.transform.position = myTr.transform.position;
        camTr.transform.rotation = myTr.transform.rotation;
	}
}
