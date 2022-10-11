using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour {

	private int mPos;
	private MovimentatoreCamera mMovimentatore = null;
	private AudioSource mSuonoCamera;
	private GameManager mGameManager;
	private InputManager mInputManager;

	private bool mInvertito;
	private bool mToGoDown = false;

	// Use this for initialization
	void Start () {
		mPos = 1;
		mInvertito = false;
		mMovimentatore = GetComponent<MovimentatoreCamera> ();
		mSuonoCamera = GetComponent<AudioSource> ();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		bool checkSinistra = mInputManager.IsLeftPressed ();
		bool checkDestra = mInputManager.IsRightPressed ();
		bool checkSu = mInputManager.IsUpPressed ();
		bool checkGiu = mInputManager.IsDownPressed ();
		bool checkRuota = mInputManager.IsCameraRotatePressed ();

		if ((checkSinistra || checkDestra || checkSu || checkGiu || checkRuota || mToGoDown) && mMovimentatore.isFermo () && mGameManager.IsGameRunning()) {

			if (mToGoDown) {
				if (mInvertito) {
					if (mPos < 5) {
						mPos += 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					} else if (mPos > 4) {
						mPos -= 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					}
					mToGoDown = true;
				} else {
					if (mPos > 4) {
						mPos -= 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					} else if (mPos < 5) {
						mPos += 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					}
				}
				mToGoDown = false;
			}

			if (checkGiu) {
				mMovimentatore.ruota();
				mInvertito = !mInvertito;
				mGameManager.SetCameraRotation (mInvertito);
				mGameManager.SetCameraHasJustRotated (true);
				mToGoDown = true;
			}

			if (mInvertito) {
				if (checkSinistra) {
					switch (mPos) {
					case 1:
						mPos = 4;
						break;
					case 5:
						mPos = 8;
						break;
					default:
						mPos = mPos - 1;
						break;
					}
					mSuonoCamera.enabled = false;
					mSuonoCamera.enabled = true;
				}

				if (checkDestra) {
					switch (mPos) {
					case 4:
						mPos = 1;
						break;
					case 8:
						mPos = 5;
						break;
					default:
						mPos = mPos + 1;
						break;
					}
					mSuonoCamera.enabled = false;
					mSuonoCamera.enabled = true;
				}
			} else {
				if (checkDestra) {
					switch (mPos) {
					case 1:
						mPos = 4;
						break;
					case 5:
						mPos = 8;
						break;
					default:
						mPos = mPos - 1;
						break;
					}
					mSuonoCamera.enabled = false;
					mSuonoCamera.enabled = true;
				}

				if (checkSinistra) {
					switch (mPos) {
					case 4:
						mPos = 1;
						break;
					case 8:
						mPos = 5;
						break;
					default:
						mPos = mPos + 1;
						break;
					}

					mSuonoCamera.enabled = false;
					mSuonoCamera.enabled = true;
				}
			}

			mGameManager.SetCameraPosition (mPos);
		}
	}

	public int GetPosizione (){
		return mPos;
	}
}
