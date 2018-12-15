using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour {
	public Animator CharacterAnimator;


	void Start () {
		CharacterAnimator = GetComponent<Animator> ();
	}
	
	void Update () {
		movement ();
		print (CharacterAnimator.GetInteger ("numParameter"));
	}
	public void movement (){


		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (new Vector2 (0, -7) * Time.deltaTime);
			CharacterAnimator.SetInteger ("numParameter", 2);
			CharacterAnimator.SetBool ("BW", false);
			CharacterAnimator.SetBool ("FW", true);
			CharacterAnimator.SetBool ("left", false);
			CharacterAnimator.SetBool ("right", false);
		} else if(CharacterAnimator.GetBool("FW")==true)  {
			CharacterAnimator.SetInteger ("numParameter", 0);
		}

		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (new Vector2 (0, 7) * Time.deltaTime);
			CharacterAnimator.SetInteger ("numParameter", 1);
			CharacterAnimator.SetBool ("BW", true);
			CharacterAnimator.SetBool ("FW", false);
			CharacterAnimator.SetBool ("left", false);
			CharacterAnimator.SetBool ("right", false);
		} else if(CharacterAnimator.GetBool("BW")==true) {
			CharacterAnimator.SetInteger ("numParameter", 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (new Vector2 (-7, 0) * Time.deltaTime);
			CharacterAnimator.SetInteger ("numParameter", 4);
			CharacterAnimator.SetBool ("BW", false);
			CharacterAnimator.SetBool ("FW", false);
			CharacterAnimator.SetBool ("left", true);
			CharacterAnimator.SetBool ("right", false);
		} else if(CharacterAnimator.GetBool("left")==true) {
			CharacterAnimator.SetInteger ("numParameter", 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (new Vector2 (7, 0) * Time.deltaTime);
			CharacterAnimator.SetInteger ("numParameter", 3);
			CharacterAnimator.SetBool ("BW", false);
			CharacterAnimator.SetBool ("FW", false);
			CharacterAnimator.SetBool ("left", false);
			CharacterAnimator.SetBool ("right", true);
		} else if(CharacterAnimator.GetBool("right")==true) {
			CharacterAnimator.SetInteger ("numParameter", 0);
		}
	}
	//later
	public void ResetAnims(){
		
	}
}
