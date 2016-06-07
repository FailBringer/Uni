using UnityEngine;
using System.Collections;

public class CardView : MonoBehaviour {

	// Use this for initialization
	public Sprite skin;
	public Sprite cardSprite;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown (0)) {
			ViewCardInHand();		
		}
	}

	public void ViewCardInHand() {
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
		if (hit.collider != null) {
			Debug.Log ("HitFound");
			if(hit.transform.parent.name == "MyCardPlaces"){
				Animate();
				Debug.Log ("Ray Hit " + hit.transform.name);
				cardSprite = hit.transform.GetComponent<Place>().GetCard ().GetComponent<SpriteRenderer>().sprite;
			}
		}
	}

	public void StopAnimation() {
		Animator animator = GetComponent<Animator> ();
		animator.SetBool ("Change", false);
	}

	public void Animate() {
		Animator animator = GetComponent<Animator> ();
		animator.SetBool ("Change", true);
	}

	public void ShowSkin(){
		GetComponent<SpriteRenderer> ().sprite = skin;
		}
	public void ShowCard(){
		GetComponent<SpriteRenderer> ().sprite = cardSprite;
	}
}
