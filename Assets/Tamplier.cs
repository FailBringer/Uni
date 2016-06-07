using UnityEngine;
using System.Collections;

public class Tamplier : MonoBehaviour {
	public enum Positions {Leader,Avanguard,Flank,Rear
	};
	public enum Statuses{OnHand,Played,Died};
	public Positions position;
	private int maxHp = 6;
	public int hp = 6;
	public int dmg = 1;
	public int totalDamage = 1;
	public Statuses status = Statuses.OnHand;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int bonusDamage = AvanguardAbility ();
		totalDamage = bonusDamage + dmg;
	}

	private int AvanguardAbility(){
		int bonusDmg = 0;
		if (status == Statuses.Played) {
			if(position==Positions.Avanguard){
				bonusDmg = maxHp-hp;
			}
		}
		return bonusDmg; 
	}

	private void FlankAbility(){

		}
}
