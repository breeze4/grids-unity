using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerZone : MonoBehaviour {
	
	public GameObject plate;
	
	public List<PlayerNode> nodeList;
	
	public bool nodesActive = false;
	public bool isActive = false;
	
	private float zoneRadius = 5.0f;
	
	// Use this for initialization
	void Start () {
		plate.renderer.enabled = false;
		nodeList = new List<PlayerNode>(4);
		FindNodes();
	}
	
	void Update() {
		
	}
	
	public void CheckIfActive() {
		if(nodesActive) {
			isActive = true;
			nodesActive = false;
			plate.renderer.enabled = true;
			Debug.Log ("Zone activated: zone active");
		}
		else {
			if(!isActive) {
				NodesActive();
			}
		}
	}
	
	bool NodesActive() {
		if(nodeList[0].isActive && nodeList[1].isActive && nodeList[2].isActive && nodeList[3].isActive) {
			nodesActive = true;
			CheckIfActive();
		}
		return nodesActive;
	}
	
	void FindNodes() {
		Collider[] cols = Physics.OverlapSphere(transform.position, zoneRadius);
		
		foreach(Collider col in cols) {
			if(col.transform.gameObject.tag == "PlayerNode") {
				Debug.Log("Added to nodeList: " + col.transform.gameObject.name);
				nodeList.Add(col.GetComponent<PlayerNode>());
			}
			
		}
	}
}
