using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ZoneManager : MonoBehaviour {
	
	public List<PlayerZone> zones;
	public List<GameObject> activatedZones;

	// Use this for initialization
	void Start () {
		GameObject[] zoneObjects = GameObject.FindGameObjectsWithTag ("PlayerZone");
		foreach(GameObject zone in zoneObjects) {
			zones.Add(zone.GetComponent<PlayerZone>());
		}
	}
	
	// Update is called once per frame
	void ZoneActivate (int zoneId) {
		Debug.Log ("ZoneManager:ZoneActivate: " + zoneId.ToString());
	}
	
	public void CheckZones() {
		foreach(PlayerZone zone in zones) {
			zone.CheckIfActive();
		}
		
	}
}
