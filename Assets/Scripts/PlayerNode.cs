using UnityEngine;
using System.Collections;

public class PlayerNode : MonoBehaviour {
	
	public bool isActive = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	public void activate() {
		isActive = true;
	}
}
