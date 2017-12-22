using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOrder : MonoBehaviour {

    public ArrayList turn = new ArrayList();

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find("Player");
		PlayerController pc = player.GetComponent<PlayerController>();
		//turn.Add("P01 + " + pc.speed).ToString;
	}
	
	// Update is called once per frame
	void Update () {
		//set position
		GameObject playerIcon = GameObject.Find("PlayerIcon");
		GameObject turn1 = GameObject.Find("Turn1");
		GameObject turn2 = GameObject.Find("Turn2");
		GameObject turn3 = GameObject.Find("Turn3");
		GameObject turn4 = GameObject.Find("Turn4");
		GameObject turn5 = GameObject.Find("Turn5");

		Vector3 playerPOS = playerIcon.transform.position;
		Vector3 turn1POS = turn1.transform.position;

		playerPOS = turn1POS;
	}
}
