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

	// Use this for initialization
	void Start () {
		mPos = 1;
		mInvertito = false;
		mMovimentatore = GetComponent<MovimentatoreCamera> ();
		mSuonoCamera = GetComponent<AudioSource> ();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
		QualitySettings.vSyncCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		bool checkSinistra = mInputManager.IsCameraLeftPressed ();
		bool checkDestra = mInputManager.IsCameraRightPressed ();
		bool checkSu = mInputManager.IsCameraUpPressed ();
		bool checkGiu = mInputManager.IsCameraDownPressed ();
		bool checkRuota = mInputManager.IsCameraRotatePressed ();

		if ((checkSinistra || checkDestra || checkSu || checkGiu || checkRuota) && mMovimentatore.isFermo () && mGameManager.IsGameRunning()) {
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

				if (checkSu) {
					if (mPos < 5) {
						mPos += 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					}
				}
				if (checkGiu) {
					if (mPos > 4) {
						mPos -= 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					}
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

				if (checkGiu) {
					if (mPos < 5) {
						mPos += 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					}
				}
				if (checkSu) {
					if (mPos > 4) {
						mPos -= 4;
						mSuonoCamera.enabled = false;
						mSuonoCamera.enabled = true;
					}
				}
			}
			mGameManager.SetCameraPosition (mPos);

			if (checkRuota) {
				mMovimentatore.ruota();
				mInvertito = !mInvertito;
				mSuonoCamera.enabled = false;
				mSuonoCamera.enabled = true;
				mGameManager.SetCameraRotation (mInvertito);
				mGameManager.SetCameraHasJustRotated (true);
			}
		}
	}

	public int GetPosizione (){
		return mPos;
	}
}
