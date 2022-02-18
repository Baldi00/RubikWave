using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	protected bool mA, mD, mW, mS, mR, mE, mQ, mLeftArrow, mRightArrow, mUpArrow, mDownArrow;
	protected bool mEscape, mM0Down, mM0Up, mM1, mScrollUp, mScrollDown;
	
	// Update is called once per frame
	void Update () {
		mA = Input.GetKeyDown (KeyCode.A);
		mD = Input.GetKeyDown (KeyCode.D);
		mW = Input.GetKeyDown (KeyCode.W);
		mS = Input.GetKeyDown (KeyCode.S);
		mR = Input.GetKeyDown (KeyCode.R);
		mE = Input.GetKeyDown (KeyCode.E);
		mQ = Input.GetKeyDown (KeyCode.Q);
		mLeftArrow = Input.GetKeyDown (KeyCode.LeftArrow);
		mRightArrow = Input.GetKeyDown (KeyCode.RightArrow);
		mUpArrow = Input.GetKeyDown (KeyCode.UpArrow);
		mDownArrow = Input.GetKeyDown (KeyCode.DownArrow);
		mEscape = Input.GetKeyDown (KeyCode.Escape);
		mM0Down = Input.GetKeyDown (KeyCode.Mouse0);
		mM0Up = Input.GetKeyUp (KeyCode.Mouse0);
		mM1 = Input.GetKeyDown (KeyCode.Mouse1);

		float scroll = Input.GetAxis("Mouse ScrollWheel");
		mScrollUp = scroll > 0;
		mScrollDown = scroll < 0;
	}

	public bool IsCameraLeftPressed(){
		return mA || mLeftArrow;
	}

	public bool IsCameraRightPressed(){
		return mD || mRightArrow;
	}

	public bool IsCameraUpPressed(){
		return mW || mUpArrow;
	}

	public bool IsCameraDownPressed(){
		return mS || mDownArrow;
	}

	public bool IsCameraRotatePressed(){
		return mR;
	}

	public bool IsEscapePressed(){
		return mEscape;
	}

	public bool IsActionPositionUpPressed(){
		return mE;
	}

	public bool IsActionPositionDownPressed(){
		return mQ;
	}

	public bool IsActionStraightPressed(){
		return mScrollUp;
	}

	public bool IsActionReversePressed(){
		return mScrollDown;
	}

	public bool IsSolveResetShufflePressed(){
		return mM0Down;
	}

	public bool IsChangeSolveResetShufflePressed(){
		return mM1;
	}

	public bool IsLeftMousePressed(){
		return mM0Down;
	}

	public bool IsLeftMouseReleased(){
		return mM0Up;
	}
}
