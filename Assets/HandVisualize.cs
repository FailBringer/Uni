using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HandVisualize : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartCardsGetting(){
		List<int> handCards = transform.GetComponent<Cards> ().GetCardsOnHand ();
		List<GameObject> CardsObject = transform.GetComponent<Cards> ().cardPrefabs;
		foreach (int c in handCards) {
			GameObject place = GetComponent<FindPlace>().FindFirstEmptyPlace ();
			GameObject tmpGo = GameObject.Instantiate(CardsObject[c],
			                       place.transform.position,
			                       Quaternion.identity) as GameObject;
			place.GetComponent<Place>().SetCard (tmpGo);
		}
 	}
}
