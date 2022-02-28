using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour {
	
	protected MovimentatoreCamera mCamera = null;
	protected CubeManager mStatoCubo = null;
	protected AnimationManager mAnimatore = null;
	protected AudioSource mSuonoRotazione;
	protected GameManager mGameManager;
	protected InputManager mInputManager;

	// Use this for initialization
	void Start () {
		mCamera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();
		mStatoCubo = GameObject.Find ("GameManager").GetComponent<CubeManager>();
		mAnimatore = GameObject.Find ("GameManager").GetComponent<AnimationManager>();
		mSuonoRotazione = GameObject.Find ("Cubo").GetComponent<AudioSource> ();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mCamera.isFermo () && mAnimatore.isFermo () && mGameManager.IsGameRunning ()) {
			bool checkRotateLeft = mInputManager.IsActionStraightPressed ();
			bool checkRotateRight = mInputManager.IsActionReversePressed ();
			int actionPosition = mGameManager.GetActionPosition ();
			int cameraPosition = mGameManager.GetCameraPosition ();
			bool cameraRotated = mGameManager.IsCameraRotated ();
			bool gamepadTriggerMoving = mInputManager.IsGamepadTriggerMoving ();
			bool moveDone = false;

			if (gamepadTriggerMoving) {
				if (cameraPosition == 1) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveLeft (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveFront(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveBack(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveRight(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveUp(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveDown(true); moveDone = true; }
				} else if (cameraPosition == 2) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveBack (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveLeft(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveRight(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveFront(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveUp(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveDown(true); moveDone = true; }
				} else if (cameraPosition == 3) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveRight (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveBack(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveFront(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveLeft(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveUp(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveDown(true); moveDone = true; }
				} else if (cameraPosition == 4) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveFront (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveRight(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveLeft(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveBack(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveUp(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveDown(true); moveDone = true; }
				} else if (cameraPosition == 5) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveFront (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveLeft(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveRight(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveBack(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveDown(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveUp(true); moveDone = true; }
				} else if (cameraPosition == 6) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveLeft (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveBack(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveFront(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveRight(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveDown(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveUp(true); moveDone = true; }
				} else if (cameraPosition == 7) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveBack (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveRight(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveLeft(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveFront(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveDown(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveUp(true); moveDone = true; }
				} else if (cameraPosition == 8) {
					if (mInputManager.IsGamepadLeftStickUpLeft()){ mStatoCubo.MoveRight (false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownRight()){ mStatoCubo.MoveRight(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpRight()){ mStatoCubo.MoveFront(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownLeft()){ mStatoCubo.MoveFront(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickUpRight()){ mStatoCubo.MoveBack(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftStickDownLeft()){ mStatoCubo.MoveBack(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickUpLeft()){ mStatoCubo.MoveLeft(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightStickDownRight()){ mStatoCubo.MoveLeft(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftShoulder()){ mStatoCubo.MoveDown(true); moveDone = true; }
					else if (mInputManager.IsGamepadRightShoulder()){ mStatoCubo.MoveDown(false); moveDone = true; }
					else if (mInputManager.IsGamepadLeftTrigger()){ mStatoCubo.MoveUp(false); moveDone = true; }
					else if (mInputManager.IsGamepadRightTrigger()){ mStatoCubo.MoveUp(true); moveDone = true; }
				}
			}

			if (checkRotateLeft || checkRotateRight) {
				if (!cameraRotated) {
					if (checkRotateLeft) {
						if (actionPosition == 1)
							mStatoCubo.MoveLeft (cameraPosition == 2 || cameraPosition == 6);
						else if (actionPosition == 2)
							mStatoCubo.MoveRight (cameraPosition == 4 || cameraPosition == 8);
						else if (actionPosition == 3)
							mStatoCubo.MoveFront (cameraPosition == 1 || cameraPosition == 5);
						else if (actionPosition == 4)
							mStatoCubo.MoveBack (cameraPosition == 3 || cameraPosition == 7);
						else if (actionPosition == 5)
							mStatoCubo.UpAntioriario ();
						else if (actionPosition == 6)
							mStatoCubo.DownOrario ();
					} else if (checkRotateRight) {
						if (actionPosition == 1)
							mStatoCubo.MoveLeft (!(cameraPosition == 2 || cameraPosition == 6));
						else if (actionPosition == 2)
							mStatoCubo.MoveRight (!(cameraPosition == 4 || cameraPosition == 8));
						else if (actionPosition == 3)
							mStatoCubo.MoveFront (!(cameraPosition == 1 || cameraPosition == 5));
						else if (actionPosition == 4)
							mStatoCubo.MoveBack (!(cameraPosition == 3 || cameraPosition == 7));
						else if (actionPosition == 5)
							mStatoCubo.UpOrario ();
						else if (actionPosition == 6)
							mStatoCubo.DownAntioriario ();
					}
				} else {
					if (checkRotateRight) {
						if (actionPosition == 1)
							mStatoCubo.MoveLeft (cameraPosition == 2 || cameraPosition == 6);
						else if (actionPosition == 2)
							mStatoCubo.MoveRight (cameraPosition == 4 || cameraPosition == 8);
						else if (actionPosition == 3)
							mStatoCubo.MoveFront (cameraPosition == 1 || cameraPosition == 5);
						else if (actionPosition == 4)
							mStatoCubo.MoveBack (cameraPosition == 3 || cameraPosition == 7);
						else if (actionPosition == 5)
							mStatoCubo.UpAntioriario ();
						else if (actionPosition == 6)
							mStatoCubo.DownOrario ();
					} else if (checkRotateLeft) {
						if (actionPosition == 1)
							mStatoCubo.MoveLeft (!(cameraPosition == 2 || cameraPosition == 6));
						else if (actionPosition == 2)
							mStatoCubo.MoveRight (!(cameraPosition == 4 || cameraPosition == 8));
						else if (actionPosition == 3)
							mStatoCubo.MoveFront (!(cameraPosition == 1 || cameraPosition == 5));
						else if (actionPosition == 4)
							mStatoCubo.MoveBack (!(cameraPosition == 3 || cameraPosition == 7));
						else if (actionPosition == 5)
							mStatoCubo.UpOrario ();
						else if (actionPosition == 6)
							mStatoCubo.DownAntioriario ();
					}
				}
				if(actionPosition != 0){
					moveDone = true;
				}
			}

			if (moveDone) {
				mSuonoRotazione.enabled = false;
				mSuonoRotazione.enabled = true;
				mGameManager.HoFattoUnaMossa ();
				mGameManager.ControllaSeHoVinto ();
			}
		}
	}
}
