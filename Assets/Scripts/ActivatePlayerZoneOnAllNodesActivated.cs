using UnityEngine;
using System.Collections;

public class ActivatePlayerZoneOnAllNodesActivated : MonoBehaviour {

	public NodeManager nodeManager;
	private bool active = false;
	
	void Start() {
		GameObject nodeManagerObject = GameObject.FindGameObjectWithTag ("PlayerNodeManager");
		nodeManager = nodeManagerObject.GetComponent<NodeManager>();
	}
	
	void ZoneActivate() {
		Debug.Log ("ActivatePlayerZoneOnAllNodesActivated:ZoneActivate");
		active = true;
	}
}
