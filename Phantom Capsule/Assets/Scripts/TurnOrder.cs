using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrder : MonoBehaviour {
	
	public Transform[] iconLocation;
	public float transitionSpeed;
	public Transform playerView;
    public ArrayList turn = new ArrayList();

	// Use this for initialization
	void Start () {
		//GameObject player = GameObject.Find("Player");
		//PlayerController pc = player.GetComponent<PlayerController>();
		//turn.Add("P01 + " + pc.speed).ToString;
	}
	
	// Update is called once per frame
	void Update () {
		GameObject playerIcon = GameObject.Find("playerIcon");
		pIcon picon = playerIcon.GetComponent<pIcon>();
		picon.move();

		if(Input.GetKeyDown(KeyCode.Alpha1)){
			playerView = iconLocation [0];
		}
	}
}
