using UnityEngine;
using System.Collections;

public class GridManager : MonoBehaviour {
	
	public GameObject zoneType;
	public GameObject nodeType;
	
	private int ROWS = 10;
	private int COLUMNS = 6;
	private int SPACING = 4;
	private int NODE_RADIUS = 1;
	
	// Use this for initialization
	void Start () {
		
		for (int y = 0; y <= ROWS; y++) {
			for (int x = 0; x <= COLUMNS; x ++) {
				Instantiate(nodeType, new Vector3(x*SPACING,0,y*SPACING), Quaternion.identity);
			}
		}
		
		for (int y = 0; y < ROWS; y++) {
			for (int x = 0; x < COLUMNS; x ++) {
				Instantiate(zoneType, new Vector3(2*NODE_RADIUS+x*SPACING,0,2*NODE_RADIUS+y*SPACING), Quaternion.identity);
			}
		}
	}
		
		

	
	// Update is called once per frame
	void Update () {
	
	}
}
