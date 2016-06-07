using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FindPlace : MonoBehaviour {

	// Use this for initialization
	private List<Transform> childs = new List<Transform>();

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public GameObject FindFirstEmptyPlace(){
		foreach (Transform c in transform) {
			childs.Add (c);
		}
		GameObject tmpGO = null;
		foreach (Transform child in childs) {
			GameObject cardInChild = child.GetComponent<Place>().GetCard();
			if(cardInChild == null){ 
				tmpGO = child.gameObject;
				goto Find;
			}
		}
	Find:
		return tmpGO;
	}
}
