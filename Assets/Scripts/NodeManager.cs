using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NodeManager : MonoBehaviour {
	
	public List<PlayerNode> activatedNodes;
	
	private ZoneManager zoneManager;
	
	void Start () {
		activatedNodes.Clear();
		GameObject zoneManagerObject = GameObject.FindGameObjectWithTag ("PlayerZoneManager");
		zoneManager = zoneManagerObject.GetComponent<ZoneManager>();
	}
	
	public bool IsActivated(PlayerNode node) {
		if(activatedNodes.Contains(node)) {
			return true;
		}
		else {
			return false;
		}
	}
	
	public void ActivateSingleNode(PlayerNode node) {
		activatedNodes.Clear();
		activatedNodes.Add(node);
		node.activate();
		zoneManager.CheckZones();
	}
	
	public void ActivateAdditionalNodes(PlayerNode node) {
		activatedNodes.Add(node);
		node.activate();
		zoneManager.CheckZones();
	}
	
	public List<PlayerNode> GetActivatedNodes() {
		return activatedNodes;
	}
	
	public void DeactivateAllNodes() {
		activatedNodes.Clear ();
	}
}
