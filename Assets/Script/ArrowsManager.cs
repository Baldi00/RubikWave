using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsManager : MonoBehaviour {

	protected GameObject mArrowUp, mArrowDown, mArrowLeft, mArrowRight, mArrowLeftLeft, mArrowRightRight;
	protected GameObject mArrowUpReverse, mArrowDownReverse, mArrowLeftReverse, mArrowRightReverse, mArrowLeftLeftReverse, mArrowRightRightReverse;
	protected Animatore mAnimatore;
	protected GameManager mGameManager;
	protected InputManager mInputManager;
	private MovimentatoreCamera mCamera = null;
	protected int mActionPosition;

	// Use this for initialization
	void Start () {
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
		mCamera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();

		mArrowUp = GameObject.Find ("ArrowUp");
		mArrowDown = GameObject.Find ("ArrowDown");
		mArrowLeft = GameObject.Find ("ArrowLeft");
		mArrowRight = GameObject.Find ("ArrowRight");
		mArrowLeftLeft = GameObject.Find ("ArrowLeftLeft");
		mArrowRightRight = GameObject.Find ("ArrowRightRight");
		mArrowUpReverse = GameObject.Find ("ArrowUpReverse");
		mArrowDownReverse = GameObject.Find ("ArrowDownReverse");
		mArrowLeftReverse = GameObject.Find ("ArrowLeftReverse");
		mArrowRightReverse = GameObject.Find ("ArrowRightReverse");
		mArrowLeftLeftReverse = GameObject.Find ("ArrowLeftLeftReverse");
		mArrowRightRightReverse = GameObject.Find ("ArrowRightRightReverse");

		HideAllArrows ();
		mArrowUp.SetActive (true);
		mActionPosition = 0;
		mGameManager.SetActionPosition (mActionPosition);
	}
	
	// Update is called once per frame
	void Update () {
		if (mGameManager.CameraHasJustRotated ()) {
			mGameManager.SetCameraHasJustRotated (false);
			mActionPosition = 5 - mActionPosition;
			ShowActualArrow ();
			mGameManager.SetActionPosition (mActionPosition);
		}

		if (mAnimatore.isFermo () && mGameManager.IsGameRunning () && mCamera.isFermo ()) {
			ShowActualArrow ();
			if (mInputManager.IsActionPositionDownPressed())
				DecrementActionPosition ();
			else if (mInputManager.IsActionPositionUpPressed())
				IncrementActionPosition ();
			ShowActualArrow ();
			mGameManager.SetActionPosition (mActionPosition);
		} else {
			HideAllArrows ();
		}
	}

	void HideAllArrows(){
		mArrowUp.SetActive (false);
		mArrowDown.SetActive (false);
		mArrowLeft.SetActive (false);
		mArrowRight.SetActive (false);
		mArrowLeftLeft.SetActive (false);
		mArrowRightRight.SetActive (false);
		mArrowUpReverse.SetActive (false);
		mArrowDownReverse.SetActive (false);
		mArrowLeftReverse.SetActive (false);
		mArrowRightReverse.SetActive (false);
		mArrowLeftLeftReverse.SetActive (false);
		mArrowRightRightReverse.SetActive (false);
	}

	void IncrementActionPosition(){
		mActionPosition++;
		if (mActionPosition > 5)
			mActionPosition = 0;
	}

	void DecrementActionPosition(){
		mActionPosition--;
		if (mActionPosition < 0)
			mActionPosition = 5;
	}

	void ShowActualArrow() {
		HideAllArrows ();
		if ((mGameManager.GetCameraPosition () <= 4 && !mGameManager.IsCameraRotated()) || (mGameManager.GetCameraPosition () > 4 && mGameManager.IsCameraRotated())) {
			switch (mActionPosition) {
			case 0:
				mArrowUp.SetActive (true);
				break;
			case 1:
				mArrowLeftLeft.SetActive (true);
				break;
			case 2:
				mArrowLeft.SetActive (true);
				break;
			case 3:
				mArrowRight.SetActive (true);
				break;
			case 4:
				mArrowRightRight.SetActive (true);
				break;
			case 5:
				mArrowDown.SetActive (true);
				break;
			}
		} else {
			switch (mActionPosition) {
			case 0:
				mArrowUpReverse.SetActive (true);
				break;
			case 1:
				mArrowLeftLeftReverse.SetActive (true);
				break;
			case 2:
				mArrowLeftReverse.SetActive (true);
				break;
			case 3:
				mArrowRightReverse.SetActive (true);
				break;
			case 4:
				mArrowRightRightReverse.SetActive (true);
				break;
			case 5:
				mArrowDownReverse.SetActive (true);
				break;
			}
		}
	}
}
