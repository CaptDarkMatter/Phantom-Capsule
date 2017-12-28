using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocation : MonoBehaviour {

	public Transform[] cameraViews;
	public float ctransitionSpeed;
	Transform cameraView;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*GameObject playerCameraLocation = GameObject.Find("PlayerCameraLocation");
        GameObject camera = GameObject.Find("Main Camera");
        PositionC cameraPosition = camera.GetComponent <PositionC>();
        PositionC playerPosition = playerCameraLocation.GetComponent<PositionC>();

        if (Clocation == "playerCradle"){
            cameraPosition = playerPosition;
        }*/
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			cameraView = cameraViews[0];
		}
		transform.position = Vector3.Lerp(transform.position, cameraView.position, Time.deltaTime * ctransitionSpeed);
    }
}
