using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class InputManager : MonoBehaviour {

	protected bool mA, mD, mW, mS, mR, mE, mQ, mLeftArrow, mRightArrow, mUpArrow, mDownArrow;
	protected bool mEscape, mM0Down, mM0Up, mM1, mScrollUp, mScrollDown;
	protected bool mGamepadA, mGamepadB, mGamepadX, mGamepadY, mGamepadUpArrow, mGamepadDownArrow, mGamepadLeftArrow, mGamepadRightArrow;
	protected bool mGamepadEscape, mGamepadLeftShoulder, mGamepadRightShoulder;
	protected bool mGamepadLeftStickUp, mGamepadLeftStickDown, mGamepadLeftStickLeft, mGamepadLeftStickRight;
	protected bool mGamepadRightStickUp, mGamepadRightStickDown, mGamepadRightStickLeft, mGamepadRightStickRight;
	protected bool mGamepadLeftStickUpLeft, mGamepadLeftStickUpRight, mGamepadLeftStickDownLeft, mGamepadLeftStickDownRight;
	protected bool mGamepadRightStickUpLeft, mGamepadRightStickUpRight, mGamepadRightStickDownLeft, mGamepadRightStickDownRight;
	protected bool mGamepadLeftTrigger, mGamepadRightTrigger;

	bool playerIndexSet = false;
	PlayerIndex playerIndex;
	GamePadState state;
	GamePadState prevState;
	
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

		if (!playerIndexSet || !prevState.IsConnected)
		{
			for (int i = 0; i < 4; ++i)
			{
				PlayerIndex testPlayerIndex = (PlayerIndex)i;
				GamePadState testState = GamePad.GetState(testPlayerIndex);
				if (testState.IsConnected)
				{
					playerIndex = testPlayerIndex;
					playerIndexSet = true;
				}
			}
		}

		prevState = state;
		state = GamePad.GetState(playerIndex);

		mGamepadLeftShoulder = prevState.Buttons.LeftShoulder == ButtonState.Released && state.Buttons.LeftShoulder== ButtonState.Pressed;
		mGamepadRightShoulder = prevState.Buttons.RightShoulder == ButtonState.Released && state.Buttons.RightShoulder == ButtonState.Pressed;

		mGamepadA = prevState.Buttons.A == ButtonState.Released && state.Buttons.A == ButtonState.Pressed;
		mGamepadB = prevState.Buttons.B == ButtonState.Released && state.Buttons.B == ButtonState.Pressed;
		mGamepadX = prevState.Buttons.X == ButtonState.Released && state.Buttons.X == ButtonState.Pressed;
		mGamepadY = prevState.Buttons.Y == ButtonState.Released && state.Buttons.Y == ButtonState.Pressed;

		mGamepadUpArrow = prevState.DPad.Up == ButtonState.Released && state.DPad.Up == ButtonState.Pressed;
		mGamepadDownArrow = prevState.DPad.Down == ButtonState.Released && state.DPad.Down == ButtonState.Pressed;
		mGamepadLeftArrow = prevState.DPad.Left == ButtonState.Released && state.DPad.Left == ButtonState.Pressed;
		mGamepadRightArrow = prevState.DPad.Right == ButtonState.Released && state.DPad.Right == ButtonState.Pressed;

		mGamepadEscape = prevState.Buttons.Start == ButtonState.Released && state.Buttons.Start == ButtonState.Pressed;

		float stickLeftX = state.ThumbSticks.Left.X;
		float stickLeftY = state.ThumbSticks.Left.Y;
		float stickRightX = state.ThumbSticks.Right.X;
		float stickRightY = state.ThumbSticks.Right.Y;

		mGamepadLeftStickUp = stickLeftY > 0.5f && stickLeftX > -0.1f && stickLeftX < 0.1f;
		mGamepadLeftStickDown = stickLeftY < -0.5f && stickLeftX > -0.1f && stickLeftX < 0.1f;
		mGamepadLeftStickLeft = stickLeftX < -0.5f && stickLeftY > -0.1f && stickLeftY < 0.1f;
		mGamepadLeftStickRight = stickLeftX > 0.5f && stickLeftY > -0.1f && stickLeftY < 0.1f;

		mGamepadRightStickUp = stickRightY > 0.5f && stickRightX > -0.1f && stickRightX < 0.1f;
		mGamepadRightStickDown = stickRightY < -0.5f && stickRightX > -0.1f && stickRightX < 0.1f;
		mGamepadRightStickLeft = stickRightX < -0.5f && stickRightY > -0.1f && stickRightY < 0.1f;
		mGamepadRightStickRight = stickRightX > 0.5f && stickRightY > -0.1f && stickRightY < 0.1f;

		mGamepadLeftStickUpLeft = stickLeftX < 0f && stickLeftY > 0f;
		mGamepadLeftStickUpRight = stickLeftX > 0f && stickLeftY > 0f;
		mGamepadLeftStickDownLeft = stickLeftX < 0f && stickLeftY < 0f;
		mGamepadLeftStickDownRight = stickLeftX > 0f && stickLeftY < 0f;

		mGamepadRightStickUpLeft = stickRightX < 0f && stickRightY > 0f;
		mGamepadRightStickUpRight = stickRightX > 0f && stickRightY > 0f;
		mGamepadRightStickDownLeft = stickRightX < 0f && stickRightY < 0f;
		mGamepadRightStickDownRight = stickRightX > 0f && stickRightY < 0f;

		mGamepadLeftTrigger = state.Triggers.Left > 0.5f;
		mGamepadRightTrigger = state.Triggers.Right > 0.5f;

        //if (mGamepadLeftStickUp) Debug.Log("mGamepadLeftStickUp");
        //if (mGamepadLeftStickDown) Debug.Log("mGamepadLeftStickDown");
        //if (mGamepadLeftStickLeft) Debug.Log("mGamepadLeftStickLeft");
        //if (mGamepadLeftStickRight) Debug.Log("mGamepadLeftStickRight");

        //if (mGamepadRightStickUp) Debug.Log("mGamepadRightStickUp");
        //if (mGamepadRightStickDown) Debug.Log("mGamepadRightStickDown");
        //if (mGamepadRightStickLeft) Debug.Log("mGamepadRightStickLeft");
        //if (mGamepadRightStickRight) Debug.Log("mGamepadRightStickRight");

        //if(mGamepadLeftStickUpLeft) Debug.Log("mGamepadLeftStickUpLeft");
        //if(mGamepadLeftStickUpRight) Debug.Log("mGamepadLeftStickUpRight");
        //if(mGamepadLeftStickDownLeft) Debug.Log("mGamepadLeftStickDownLeft");
        //if(mGamepadLeftStickDownRight) Debug.Log("mGamepadLeftStickDownRight");

        //if(mGamepadRightStickUpLeft) Debug.Log("mGamepadRightStickUpLeft");
        //if(mGamepadRightStickUpRight) Debug.Log("mGamepadRightStickUpRight");
        //if(mGamepadRightStickDownLeft) Debug.Log("mGamepadRightStickDownLeft");
        //if(mGamepadRightStickDownRight) Debug.Log("mGamepadRightStickDownRight");


        /*
		if (Input.GetKey ("joystick button 0")) {
			GamePad.SetVibration (playerIndex, .1f, .1f);
		}
		if(Input.GetKey ("joystick button 1")){
			GamePad.SetVibration (playerIndex, 0, 0);
		}*/


        float scroll = Input.GetAxis("Mouse ScrollWheel");
		mScrollUp = scroll > 0;
		mScrollDown = scroll < 0;
	}

	public bool IsGamepadConnected() {
		return prevState.IsConnected;
    }

	public bool IsLeftPressed(){
		return mA || mLeftArrow || mGamepadLeftArrow;
	}

	public bool IsRightPressed(){
		return mD || mRightArrow || mGamepadRightArrow;
	}

	public bool IsUpPressed(){
		return mW || mUpArrow || mGamepadUpArrow;
	}

	public bool IsDownPressed(){
		return mS || mDownArrow || mGamepadDownArrow;
	}

	public bool IsCameraRotatePressed(){
		return mR || mGamepadX;
	}

	public bool IsEscapePressed(){
		return mEscape || mGamepadEscape;
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

	public bool IsSolveResetShuffleGamepadPressed() {
		return mGamepadY;
	}
	public bool IsChangeSolveResetShuffleGamepadPressed() {
		return mGamepadX;
	}

	public bool IsSolveResetShufflePressed(){
		return mM0Down;
	}

	public bool IsChangeSolveResetShufflePressed() {
		return mM1 || mGamepadX;
	}

	public bool IsLeftMousePressed(){
		return mM0Down;
	}

	public bool IsLeftMouseReleased(){
		return mM0Up;
	}

	public bool IsGamepadLeftStickUp(){
		return mGamepadLeftStickUp;
	}

	public bool IsGamepadLeftStickDown(){
		return mGamepadLeftStickDown;
	}

	public bool IsGamepadLeftStickLeft(){
		return mGamepadLeftStickLeft;
	}

	public bool IsGamepadLeftStickRight(){
		return mGamepadLeftStickRight;
	}

	public bool IsGamepadRightStickUp(){
		return mGamepadRightStickUp;
	}

	public bool IsGamepadRightStickDown(){
		return mGamepadRightStickDown;
	}

	public bool IsGamepadRightStickLeft(){
		return mGamepadRightStickLeft;
	}

	public bool IsGamepadRightStickRight(){
		return mGamepadRightStickRight;
	}

	public bool IsGamepadLeftStickUpLeft(){
		return mGamepadLeftStickUpLeft;
	}

	public bool IsGamepadLeftStickUpRight(){
		return mGamepadLeftStickUpRight;
	}

	public bool IsGamepadLeftStickDownLeft(){
		return mGamepadLeftStickDownLeft;
	}

	public bool IsGamepadLeftStickDownRight(){
		return mGamepadLeftStickDownRight;
	}

	public bool IsGamepadRightStickUpLeft(){
		return mGamepadRightStickUpLeft;
	}

	public bool IsGamepadRightStickUpRight(){
		return mGamepadRightStickUpRight;
	}

	public bool IsGamepadRightStickDownLeft(){
		return mGamepadRightStickDownLeft;
	}

	public bool IsGamepadRightStickDownRight(){
		return mGamepadRightStickDownRight;
	}

	public bool IsGamepadLeftShoulder(){
		return mGamepadLeftShoulder;
	}
	public bool IsGamepadRightShoulder(){
		return mGamepadRightShoulder;
	}
	public bool IsGamepadLeftTrigger(){
		return mGamepadLeftTrigger;
	}
	public bool IsGamepadRightTrigger(){
		return mGamepadRightTrigger;
	}

	public bool IsGamepadTriggerMoving(){
		return mGamepadLeftStickLeft || mGamepadLeftStickRight || mGamepadLeftStickUp || mGamepadLeftStickDown ||
		mGamepadRightStickLeft || mGamepadRightStickRight || mGamepadRightStickUp || mGamepadRightStickDown ||
		mGamepadLeftStickUpLeft || mGamepadLeftStickUpRight || mGamepadLeftStickDownLeft || mGamepadLeftStickDownRight ||
		mGamepadRightStickUpLeft || mGamepadRightStickUpRight || mGamepadRightStickDownLeft || mGamepadRightStickDownRight ||
		mGamepadRightTrigger || mGamepadLeftTrigger || mGamepadRightShoulder || mGamepadLeftShoulder;
	}

	public bool IsGamepadBPressed() {
		return mGamepadB;
    }

}
