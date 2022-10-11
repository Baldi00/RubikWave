using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MescolaRisolviReset : MonoBehaviour {

	private Text mMescola, mRisolvi, mReset;
	protected Text mInfoOggetto;

	protected int mIndex = 0;

	protected GameObject mCongratulazioni;

	protected GameManager mGameManager;
	protected InputManager mInputManager;
	protected AnimationManager mAnimatore;

	protected StatisticheInGame mStatistiche;

	void Start () {
		mGameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find ("GameManager").GetComponent<InputManager> ();
		mAnimatore = GameObject.Find ("GameManager").GetComponent<AnimationManager> ();
		mStatistiche = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame> ();

		mCongratulazioni = mGameManager.GetCongratulazioni();

		mMescola = GameObject.Find ("Mescola").GetComponent<Text> ();
		mRisolvi = GameObject.Find ("Risolvi").GetComponent<Text> ();
		mReset = GameObject.Find ("Reset").GetComponent<Text> ();
		mInfoOggetto = GameObject.Find ("InfoVarie").GetComponent<Text> ();

		mMescola.enabled = true;
		mRisolvi.enabled = false;
		mReset.enabled = false;

		switch (mIndex) {
		case 0:
			mMescola.enabled = true;
			break;
		case 1:
			mRisolvi.enabled = true;
			break;
		case 2:
			mReset.enabled = true;
			break;
		}
	}

	void OnMouseEnter(){
		Color azzurroChiaro = new Color ();
		ColorUtility.TryParseHtmlString ("#00FFFFFF", out azzurroChiaro);
		mMescola.color = azzurroChiaro;
		mRisolvi.color = azzurroChiaro;
		mReset.color = azzurroChiaro;
	}

	void OnMouseOver(){

		switch (mIndex) {
		case 0:
			mInfoOggetto.text = "Mescola il cubo\nTASTO DESTRO DEL MOUSE PER CAMBIARE AZIONE";
			break;
		case 1:
			mInfoOggetto.text = "Risolvi il cubo con intelligenza artificiale\nTASTO DESTRO DEL MOUSE PER CAMBIARE AZIONE";
			break;
		case 2:
			mInfoOggetto.text = "Riporta il cubo allo stato iniziale\nTASTO DESTRO DEL MOUSE PER CAMBIARE AZIONE";
			break;
		}

		if (mInputManager.IsSolveResetShufflePressed() && mGameManager.IsGameRunning () && mAnimatore.isFermo ()) {
			if (mIndex == 0) {
				mStatistiche.TimeReset ();
				mGameManager.ResetMosseEseguite ();
				mCongratulazioni.SetActive (false);
				mGameManager.AIReset ();

				int numMosseMescola = mGameManager.GetNumMosseMescola ();
				int velocitaMescola = mGameManager.GetVelocitaMescola ();

				int[] mMosseInizializzazione = new int[numMosseMescola];
				for (int index = 0; index < numMosseMescola; index++) {
					mMosseInizializzazione [index] = Random.Range (1, 13);
				}
				mAnimatore.SetStatoStoMescolando (true);
				mAnimatore.EseguiPiuMosse (mMosseInizializzazione, velocitaMescola);

			} else if (mIndex == 1) {
				mGameManager.AISolve ();
			} else if (mIndex == 2) {
				mCongratulazioni.SetActive (false);
				mGameManager.ResetMosseEseguite ();
				mStatistiche.TimeReset ();
				mGameManager.ResetCubo ();
				mGameManager.AIReset ();
			}
		} else if (mInputManager.IsChangeSolveResetShufflePressed() && mGameManager.IsGameRunning ()) {
			mIndex++;
			if (mIndex > 2) {
				mIndex = 0;
			}

			mMescola.enabled = false;
			mRisolvi.enabled = false;
			mReset.enabled = false;

			switch (mIndex) {
			case 0:
				mMescola.enabled = true;
				break;
			case 1:
				mRisolvi.enabled = true;
				break;
			case 2:
				mReset.enabled = true;
				break;
			}
		}
	}

	void OnMouseExit(){
		Color azzurro = new Color ();
		ColorUtility.TryParseHtmlString ("#00CAFFFF", out azzurro);
		mMescola.color = azzurro;
		mRisolvi.color = azzurro;
		mReset.color = azzurro;
		mInfoOggetto.text = "";
	}

    private void Update() {
		if (mInputManager.IsSolveResetShuffleGamepadPressed() && mGameManager.IsGameRunning() && mAnimatore.isFermo()) {
			if (mIndex == 0) {
				mStatistiche.TimeReset();
				mGameManager.ResetMosseEseguite();
				mCongratulazioni.SetActive(false);
				mGameManager.AIReset();

				int numMosseMescola = mGameManager.GetNumMosseMescola();
				int velocitaMescola = mGameManager.GetVelocitaMescola();

				int[] mMosseInizializzazione = new int[numMosseMescola];
				for (int index = 0; index < numMosseMescola; index++) {
					mMosseInizializzazione[index] = Random.Range(1, 13);
				}
				mAnimatore.SetStatoStoMescolando(true);
				mAnimatore.EseguiPiuMosse(mMosseInizializzazione, velocitaMescola);

			}
			else if (mIndex == 1) {
				mGameManager.AISolve();
			}
			else if (mIndex == 2) {
				mCongratulazioni.SetActive(false);
				mGameManager.ResetMosseEseguite();
				mStatistiche.TimeReset();
				mGameManager.ResetCubo();
				mGameManager.AIReset();
			}
		}
		else if (mInputManager.IsChangeSolveResetShuffleGamepadPressed() && mGameManager.IsGameRunning()) {
			mIndex++;
			if (mIndex > 2) {
				mIndex = 0;
			}

			mMescola.enabled = false;
			mRisolvi.enabled = false;
			mReset.enabled = false;

			switch (mIndex) {
				case 0:
					mMescola.enabled = true;
					break;
				case 1:
					mRisolvi.enabled = true;
					break;
				case 2:
					mReset.enabled = true;
					break;
			}
		}
	}
}
