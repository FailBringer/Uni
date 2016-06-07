using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shuffle {

	// Use this for initialization
	private List<int> Deck = new List<int>();

	public Shuffle(){
		int c=0;
		while(c<25){
			int cardId = Random.Range(0,25);
			if (!Deck.Contains (cardId)){
				Deck.Add (cardId);
				c++;
			}
		}
	}
	public List<int> GetDeck(){
		return Deck;
	}
}