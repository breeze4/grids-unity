using UnityEngine;
using System.Collections;

public class ActivatePlayerNodeOnClicked : MonoBehaviour {
	
	private NodeManager nodeManager;
	private ZoneManager zoneManager;
	
	void Start() {
		GameObject nodeManagerObject = GameObject.FindGameObjectWithTag ("PlayerNodeManager");
		nodeManager = nodeManagerObject.GetComponent<NodeManager>();
		GameObject zoneManagerObject = GameObject.FindGameObjectWithTag ("PlayerZoneManager");
		zoneManager = zoneManagerObject.GetComponent<ZoneManager>();
	}
	
	void Clicked() {
		if(Input.GetKey(KeyCode.LeftShift)  || Input.GetKey(KeyCode.RightShift)) {
			nodeManager.ActivateAdditionalNodes(gameObject.GetComponent<PlayerNode>());
			
		}
		else {
			nodeManager.ActivateSingleNode(gameObject.GetComponent<PlayerNode>());
		}
		
	}
}
