using UnityEngine;
using System.Collections;

public class CardView : MonoBehaviour {

	// Use this for initialization
	public Sprite skin;
	public Sprite cardSprite;
	private bool rotate;
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
			if (hit.transform.name == "CardInfo" && !rotate) {
				Rotate ();
				rotate = true;
			} else if (hit.transform.name == "CardInfo" && rotate) {
				RotateBack();
				rotate = false;
			} 
			else {
				if (hit.transform.parent.name == "MyCardPlaces") {
					Animate ();
					Debug.Log ("Ray Hit " + hit.transform.name);
					cardSprite = hit.transform.GetComponent<Place> ().GetCard ().GetComponent<SpriteRenderer> ().sprite;
				}
			}
		}
	}

	public void StopAnimation() {
		Animator animator = GetComponent<Animator> ();
		animator.SetBool ("Change", false);
		//transform.rotation = Quaternion.Euler (0, 0, 0);
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

	public void Rotate(){
		Animator animator = GetComponent<Animator> ();
			animator.SetBool("Rotate", true);
	}

	public void RotateBack(){
		Animator animator = GetComponent<Animator> ();
			animator.SetBool("RotateBack", true);
	}

	public void StopRotate(){
		Animator animator = GetComponent<Animator> ();
		if (animator.GetBool ("Rotate")) {
			animator.SetBool ("Rotate", false);
			transform.rotation = Quaternion.Euler (0, 0, 180);
		}
		if (animator.GetBool ("RotateBack")) {
			animator.SetBool("RotateBack", false);
			transform.rotation = Quaternion.Euler (0,0,0);
		}
	}
	

}
