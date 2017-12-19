using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocation : MonoBehaviour {

    public static string currentTurn = "playerCradle"; // to be moved to Turn Order later
    public string Clocation = currentTurn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject playerCameraLocation = GameObject.Find("PlayerCameraLocation");
        GameObject camera = GameObject.Find("Main Camera");
        PositionC cameraPosition = camera.GetComponent <PositionC>();
        PositionC playerPosition = playerCameraLocation.GetComponent<PositionC>();

        if (Clocation == "playerCradle"){
            cameraPosition = playerPosition;
        }
    }
}
