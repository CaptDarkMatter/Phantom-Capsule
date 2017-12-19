using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionC : MonoBehaviour {

    Vector3 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = transform.position;
	}
}
