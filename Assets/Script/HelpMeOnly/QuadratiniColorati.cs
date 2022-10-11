using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadratiniColorati : MonoBehaviour {
	
	[SerializeField]
	private MovimentoCamera mCamera;

	[SerializeField]
	GameManager_HelpMe mGameManagerHelpMe;

	private AnimationManager mAnimatore;

	void Start(){
		mAnimatore = GameObject.Find ("GameManager").GetComponent<AnimationManager> ();
	}

	void Update () {
		switch (tag) {
		case "Front":
			if (mGameManagerHelpMe.isFaseSceltaColori() && (mCamera.GetPosizione () == 1 || mCamera.GetPosizione () == 4 || mCamera.GetPosizione () == 5 || mCamera.GetPosizione () == 8))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Back":
			if (mGameManagerHelpMe.isFaseSceltaColori() && (mCamera.GetPosizione () == 2 || mCamera.GetPosizione () == 3 || mCamera.GetPosizione () == 6 || mCamera.GetPosizione () == 7))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Left":
			if (mGameManagerHelpMe.isFaseSceltaColori() && (mCamera.GetPosizione () == 1 || mCamera.GetPosizione () == 2 || mCamera.GetPosizione () == 5 || mCamera.GetPosizione () == 6))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Right":
			if (mGameManagerHelpMe.isFaseSceltaColori() && (mCamera.GetPosizione () == 3 || mCamera.GetPosizione () == 4 || mCamera.GetPosizione () == 7 || mCamera.GetPosizione () == 8))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Up":
			if (mGameManagerHelpMe.isFaseSceltaColori() && (mCamera.GetPosizione () == 1 || mCamera.GetPosizione () == 2 || mCamera.GetPosizione () == 3 || mCamera.GetPosizione () == 4))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Down":
			if (mGameManagerHelpMe.isFaseSceltaColori() && (mCamera.GetPosizione () == 5 || mCamera.GetPosizione () == 6 || mCamera.GetPosizione () == 7 || mCamera.GetPosizione () == 8))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		}
	}

	void OnMouseOver() {
		if (Input.GetKeyDown (KeyCode.Mouse0) && mGameManagerHelpMe.IsGameRunning () && mAnimatore.isFermo()) {
			GetComponent<Renderer> ().material.color = mGameManagerHelpMe.getNextOrPreviousColorByActualColor (GetComponent<Renderer> ().material.color, true);
		} else if (Input.GetKeyDown (KeyCode.Mouse1)) {
			GetComponent<Renderer> ().material.color = mGameManagerHelpMe.getNextOrPreviousColorByActualColor (GetComponent<Renderer> ().material.color, false);
		}
	}
}
