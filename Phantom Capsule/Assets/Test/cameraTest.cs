using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTest : MonoBehaviour {

	public Transform[] cameraViews;
	public float ctransitionSpeed;
	Transform cameraView;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			cameraView = cameraViews[0];
		}

		if(Input.GetKeyDown(KeyCode.Alpha2)){
			cameraView = cameraViews[1];
		}
		this.transform.position = Vector3.Lerp(this.transform.position, cameraView.position, Time.deltaTime * ctransitionSpeed);
	}
}
