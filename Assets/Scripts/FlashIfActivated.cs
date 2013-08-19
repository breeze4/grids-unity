using UnityEngine;
using System.Collections;

public class FlashIfActivated : MonoBehaviour {
	
	public float flashRate = 1.0f;
	public GameObject nodeObject = null;
	
	private Color originalColor;
	private NodeManager nodeManager;
	private bool coroutineRunning = false;
	
	// Use this for initialization
	void Start () {
		if(nodeObject == null) {
			nodeObject = gameObject;
		}
		GameObject nodeManagerObject = GameObject.FindGameObjectWithTag ("PlayerNodeManager");
		nodeManager = nodeManagerObject.GetComponent<NodeManager>();
		//renderer.material gives you instance of the material for just that object and duplicates the material on the object
		originalColor = renderer.material.color; 
	}
	
	void Update() {
		//check to see if our unit is selected, if it is - flash
		if(nodeManager.IsActivated(nodeObject.GetComponent<PlayerNode>())) {
			if(!coroutineRunning) {
				coroutineRunning = true;
				StartCoroutine("Flash");
			}
		}
		else {
			coroutineRunning = false;
			StopAllCoroutines(); //only coroutines acting on this object
			renderer.material.color = originalColor;
		}
	}
	
	// 
	IEnumerator Flash () {
		float t = 0.0f;
		while(t < flashRate) {
			renderer.material.color = Color.Lerp(originalColor, Color.white, t/flashRate);
			t += Time.deltaTime;
			yield return null;	
		}
		renderer.material.color = Color.white;
		StartCoroutine("Return");
	}
	
	IEnumerator Return() {
		float t = 0.0f;
		while(t < flashRate) {
			renderer.material.color = Color.Lerp(Color.white, originalColor, t/flashRate);
			t += Time.deltaTime;
			yield return null;	
		}
		renderer.material.color = originalColor;
		StartCoroutine("Flash");
	}
}
