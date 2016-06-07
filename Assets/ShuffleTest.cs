using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShuffleTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int interations = 1;
		while (interations>0) {
			Shuffle s = new Shuffle ();
			List<int> testDeck = s.GetDeck ();
			bool status = true;
			for (int i=0; i<25; i++) {
				status &= testDeck.Contains (i);
			}
			Debug.Log (status.ToString ());
			testDeck.Sort ();
			string str = "";
			foreach (int c in testDeck) {
				str += c.ToString () + " ";
			}
			Debug.Log (str);
			interations --;
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
