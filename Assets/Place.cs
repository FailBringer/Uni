using UnityEngine;
using System.Collections;

public class Place : MonoBehaviour {

	private GameObject card;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public GameObject GetCard(){
		return card;
	}

	public void SetCard(GameObject c){
		card = c;
	}
}
