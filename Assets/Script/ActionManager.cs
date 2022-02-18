using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour {
	
	protected MovimentatoreCamera mCamera = null;
	protected StatoCubo mStatoCubo = null;
	protected Animatore mAnimatore = null;
	protected AudioSource mSuonoRotazione;
	protected GameManager mGameManager;
	protected InputManager mInputManager;

	protected int mMinDistance = 115;

	// Use this for initialization
	void Start () {
		mCamera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();
		mStatoCubo = GameObject.Find ("GameManager").GetComponent<StatoCubo>();
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
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
		}


		/*if (mCamera.isFermo () && mAnimatore.isFermo () && mGameManager.IsGameRunning()) {
			bool checkRotateLeft = mInputManager.IsActionStraightPressed();
			bool checkRotateRight = mInputManager.IsActionReversePressed();

			if (checkRotateLeft || checkRotateRight) {
				int cameraPosition = mGameManager.GetCameraPosition ();
				bool cameraRotated = mGameManager.IsCameraRotated ();
				int actionPosition = mGameManager.GetActionPosition ();

				switch (actionPosition) {
				case 0:
					switch (cameraPosition) {
					case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: 
						if (!cameraRotated) {
							if (checkRotateLeft)
								mStatoCubo.UpAntioriario ();
							else
								mStatoCubo.UpOrario ();
						} else {
							if (checkRotateLeft)
								mStatoCubo.DownAntioriario ();
							else
								mStatoCubo.DownOrario ();
						}
						break;
					}
					break;
				case 1:
					if (!cameraRotated) {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.BackAntioriario ();
							else
								mStatoCubo.BackOrario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.RightAntioriario ();
							else
								mStatoCubo.RightOrario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.FrontAntioriario ();
							else
								mStatoCubo.FrontOrario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.LeftAntioriario ();
							else
								mStatoCubo.LeftOrario ();
							break;
						}
					} else {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.RightAntioriario ();
							else
								mStatoCubo.RightOrario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.FrontAntioriario ();
							else
								mStatoCubo.FrontOrario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.LeftAntioriario ();
							else
								mStatoCubo.LeftOrario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.BackAntioriario ();
							else
								mStatoCubo.BackOrario ();
							break;
						}
					}
					break;
				case 2:
					if (!cameraRotated) {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.LeftAntioriario ();
							else
								mStatoCubo.LeftOrario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.BackAntioriario ();
							else
								mStatoCubo.BackOrario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.RightAntioriario ();
							else
								mStatoCubo.RightOrario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.FrontAntioriario ();
							else
								mStatoCubo.FrontOrario ();
							break;
						}
					} else {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.FrontAntioriario ();
							else
								mStatoCubo.FrontOrario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.LeftAntioriario ();
							else
								mStatoCubo.LeftOrario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.BackAntioriario ();
							else
								mStatoCubo.BackOrario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.RightAntioriario ();
							else
								mStatoCubo.RightOrario ();
							break;
						}
					}
					break;
				case 3:
					if (!cameraRotated) {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.FrontOrario ();
							else
								mStatoCubo.FrontAntioriario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.LeftOrario ();
							else
								mStatoCubo.LeftAntioriario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.BackOrario ();
							else
								mStatoCubo.BackAntioriario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.RightOrario ();
							else
								mStatoCubo.RightAntioriario ();
							break;
						}
					} else {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.LeftOrario ();
							else
								mStatoCubo.LeftAntioriario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.BackOrario ();
							else
								mStatoCubo.BackAntioriario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.RightOrario ();
							else
								mStatoCubo.RightAntioriario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.FrontOrario ();
							else
								mStatoCubo.FrontAntioriario ();
							break;
						}
					}
					break;
				case 4:
					if (!cameraRotated) {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.RightOrario ();
							else
								mStatoCubo.RightAntioriario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.FrontOrario ();
							else
								mStatoCubo.FrontAntioriario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.LeftOrario ();
							else
								mStatoCubo.LeftAntioriario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.BackOrario ();
							else
								mStatoCubo.BackAntioriario ();
							break;
						}
					} else {
						switch (cameraPosition) {
						case 1: case 5:
							if (checkRotateLeft)
								mStatoCubo.BackOrario ();
							else
								mStatoCubo.BackAntioriario ();
							break;
						case 2: case 6:
							if (checkRotateLeft)
								mStatoCubo.RightOrario ();
							else
								mStatoCubo.RightAntioriario ();
							break;
						case 3: case 7:
							if (checkRotateLeft)
								mStatoCubo.FrontOrario ();
							else
								mStatoCubo.FrontAntioriario ();
							break;
						case 4: case 8:
							if (checkRotateLeft)
								mStatoCubo.LeftOrario ();
							else
								mStatoCubo.LeftAntioriario ();
							break;
						}
					}
					break;
				case 5:
					switch (cameraPosition) {
					case 1: case 2: case 3: case 4: case 5: case 6: case 7: case 8: 
						if (!cameraRotated) {
							if (checkRotateLeft)
								mStatoCubo.DownOrario ();
							else
								mStatoCubo.DownAntioriario ();
						} else {
							if (checkRotateLeft)
								mStatoCubo.UpOrario ();
							else
								mStatoCubo.UpAntioriario ();
						}
						break;
					}
					break;
				}

				mSuonoRotazione.enabled = false;
				mSuonoRotazione.enabled = true;
				mGameManager.HoFattoUnaMossa ();
				mGameManager.ControllaSeHoVinto ();
			}
		}*/
	}

	public void CalculateActionToPerform(Vector3 start, Vector3 end, string name){
		/*
		float distance = CalculateNormalizedDistance (start, end);
		Debug.Log (distance);
		if (distance > mMinDistance) {
			bool toRight = start.x < end.x;
			bool toUp = start.y < end.y;
			int cameraPosition = mGameManager.GetCameraPosition ();
			bool cameraRotated = mGameManager.IsCameraRotated ();
			bool actionDone = false;

			if (!cameraRotated) {
				if (cameraPosition == 1) {
					if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 2) {
					if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 3) {
					if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 4) {
					if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 5) {
					if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 6) {
					if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 7) {
					if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				} else if (cameraPosition == 8) {
					if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpAntioriario (); else mStatoCubo.UpOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownOrario (); else mStatoCubo.DownAntioriario(); actionDone = true; }
				}
			} else {
				if (cameraPosition == 1) {
					if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 2) {
					if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 3) {
					if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 4) {
					if(name.Equals("SwipeDownDownRightReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownDownLeftReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpRightReverse") && Is30Degrees(start, end)){ if(!toUp && toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeDownUpLeftReverse") && Is30Degrees(start, end)){ if(!toUp && !toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUpReverse") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUpReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRightReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeftReverse") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightDownReverse") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 5) {
					if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 6) {
					if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontAntioriario (); else mStatoCubo.FrontOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackOrario (); else mStatoCubo.BackAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 7) {
					if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftAntioriario (); else mStatoCubo.LeftOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightOrario (); else mStatoCubo.RightAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				} else if (cameraPosition == 8) {
					if(name.Equals("SwipeUpDownLeft") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpDownRight") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpLeft") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeUpUpRight") && Is30Degrees(start, end)){ if(toUp && !toRight) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightUp") && Is30Degrees(start, end)){ if(toUp && toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.RightAntioriario (); else mStatoCubo.RightOrario(); actionDone = true; }
					else if(name.Equals("SwipeRightRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.LeftOrario (); else mStatoCubo.LeftAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeRightDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftUp") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.DownAntioriario (); else mStatoCubo.DownOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftLeft") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.BackAntioriario (); else mStatoCubo.BackOrario(); actionDone = true; }
					else if(name.Equals("SwipeLeftRight") && Is90Degrees(start, end)){ if(toUp) mStatoCubo.FrontOrario (); else mStatoCubo.FrontAntioriario(); actionDone = true; }
					else if(name.Equals("SwipeLeftDown") && Is30Degrees(start, end)){ if(toRight) mStatoCubo.UpOrario (); else mStatoCubo.UpAntioriario(); actionDone = true; }
				}
			}

			if (actionDone) {
				mSuonoRotazione.enabled = false;
				mSuonoRotazione.enabled = true;
				mGameManager.HoFattoUnaMossa ();
				mGameManager.ControllaSeHoVinto ();
			}
		}*/
	}

	public float CalculateNormalizedDistance(Vector3 start, Vector3 end){
		int actualWidth = Screen.currentResolution.width;
		int actualHeight = Screen.currentResolution.height;

		float normalizedStartWidht = (1920 * start.x) / actualWidth;
		float normalizedStartHeight = (1080 * start.y) / actualHeight;
		float normalizedEndWidht = (1920 * end.x) / actualWidth;
		float normalizedEndHeight = (1080 * end.y) / actualHeight;

		Vector3 normalizedStart = new Vector3 (normalizedStartWidht, normalizedStartHeight);
		Vector3 normalizedEnd = new Vector3 (normalizedEndWidht, normalizedEndHeight);

		return Vector3.Distance (normalizedStart, normalizedEnd);
	}

	public bool Is30Degrees(Vector3 start, Vector3 end){
		float angle = Vector2.Angle (new Vector2 (1f, 0f), new Vector2 (end.x - start.x, end.y - start.y));
		return (angle > 0 && angle < 60) || (angle > 120 && angle < 180);
	}

	public bool Is90Degrees(Vector3 start, Vector3 end){
		float angle = Vector2.Angle (new Vector2 (1f, 0f), new Vector2 (end.x - start.x, end.y - start.y));
		return angle > 60 && angle < 120;
	}


}
