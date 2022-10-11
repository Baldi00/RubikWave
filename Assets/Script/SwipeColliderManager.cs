using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeColliderManager : MonoBehaviour {
	protected GameManager mGameManager;
	protected ActionManager mActionManager;
	protected Animatore mAnimatore;
	protected InputManager mInputManager;
	protected MovimentatoreCamera mCamera;

	protected Vector3 mStartPosition, mEndPosition;
	/*
	void Start() {
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mActionManager = GameObject.Find("GameManager").GetComponent<ActionManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
		mCamera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();
	}

	void OnMouseEnter(){
		mStartPosition = new Vector3 (-1f, -1f);
		mEndPosition = new Vector3 (-1f, -1f);
	}

	void OnMouseOver() {
		if (mAnimatore.isFermo () && mGameManager.IsGameRunning () && mCamera.isFermo ()) {
			if (mInputManager.IsLeftMousePressed ()) {
				mStartPosition = Input.mousePosition;
			}
			if (mInputManager.IsLeftMouseReleased ()) {
				mEndPosition = Input.mousePosition;
			}

			if (mStartPosition.x != -1f && mEndPosition.x != -1f && mInputManager.IsLeftMouseReleased ()) {
				mActionManager.CalculateActionToPerform (mStartPosition, mEndPosition, gameObject.name);
			}
		}
	}

	void OnMouseExit(){
		mStartPosition = new Vector3 (-1f, -1f);
		mEndPosition = new Vector3 (-1f, -1f);
	}*/
}
