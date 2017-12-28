using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pIcon : MonoBehaviour {

	public void move() {
		GameObject Turnbar = GameObject.Find("Turn Bar");
		TurnOrder turnOrder = Turnbar.GetComponent<TurnOrder>();
		this.transform.position = Vector3.Lerp(this.transform.position, turnOrder.playerView.position, Time.deltaTime * turnOrder.transitionSpeed);
	}
}
