using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
	protected StatoCubo mStatoCubo;
	protected GameManager mGameManager;
	protected StatisticheInGame mStatistiche;
	protected Animatore mAnimatore;
	
	protected GameObject CentFront,CentBack,CentRight,CentLeft,CentUp,CentDown;

	protected GameObject SpigFrontUp,SpigFrontLeft,SpigFrontRight,SpigFrontDown,SpigBackUp,SpigBackLeft,SpigBackRight,SpigBackDown,
	SpigRightUp,SpigRightLeft,SpigRightRight,SpigRightDown,SpigLeftUp,SpigLeftLeft,SpigLeftRight,SpigLeftDown,
	SpigUpUp,SpigUpLeft,SpigUpRight,SpigUpDown,SpigDownUp,SpigDownLeft,SpigDownRight,SpigDownDown;

	protected GameObject VertFrontRightUp,VertFrontRightDown,VertFrontLeftUp,VertFrontLeftDown,VertBackRightUp,VertBackRightDown,VertBackLeftUp,VertBackLeftDown,
	VertLeftRightUp,VertLeftRightDown,VertLeftLeftUp,VertLeftLeftDown,VertRightRightUp,VertRightRightDown,VertRightLeftUp,VertRightLeftDown,
	VertUpRightUp,VertUpRightDown,VertUpLeftUp,VertUpLeftDown,VertDownRightUp,VertDownRightDown,VertDownLeftUp,VertDownLeftDown;
	
	protected Color CentFrontColor,CentBackColor,CentRightColor,CentLeftColor,CentUpColor,CentDownColor;

	protected Color SpigFrontUpColor,SpigFrontLeftColor,SpigFrontRightColor,SpigFrontDownColor,SpigBackUpColor,SpigBackLeftColor,SpigBackRightColor,SpigBackDownColor,
	SpigRightUpColor,SpigRightLeftColor,SpigRightRightColor,SpigRightDownColor,SpigLeftUpColor,SpigLeftLeftColor,SpigLeftRightColor,SpigLeftDownColor,
	SpigUpUpColor,SpigUpLeftColor,SpigUpRightColor,SpigUpDownColor,SpigDownUpColor,SpigDownLeftColor,SpigDownRightColor,SpigDownDownColor;
	
	protected Color VertFrontRightUpColor,VertFrontRightDownColor,VertFrontLeftUpColor,VertFrontLeftDownColor,VertBackRightUpColor,VertBackRightDownColor,VertBackLeftUpColor,VertBackLeftDownColor,
	VertLeftRightUpColor,VertLeftRightDownColor,VertLeftLeftUpColor,VertLeftLeftDownColor,VertRightRightUpColor,VertRightRightDownColor,VertRightLeftUpColor,VertRightLeftDownColor,
	VertUpRightUpColor,VertUpRightDownColor,VertUpLeftUpColor,VertUpLeftDownColor,VertDownRightUpColor,VertDownRightDownColor,VertDownLeftUpColor,VertDownLeftDownColor;

	protected Color mBianco, mRosso, mBlu, mVerde, mGiallo, mArancione;

	protected bool mRisolvi;

	protected bool mFase1Completata, mFase2Completata, mFase3Completata, mFase4Completata, mFase5Completata, mFase6Completata, mFase7Completata, mFase8Completata;
	protected bool mFase2RossoOK, mFase2VerdeOK, mFase2BluOK, mFase2ArancioneOK;

	[SerializeField]
	protected int mVelocitaEsecuzione = 10;

	// Use this for initialization
	void Start () {
		mRisolvi = false;

		mStatoCubo = GameObject.Find ("GameManager").GetComponent<StatoCubo> ();
		mGameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		mStatistiche = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame> ();
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore> ();

		CentFront = GameObject.Find ("CentFront");
		CentBack = GameObject.Find ("CentBack");
		CentRight = GameObject.Find ("CentRight");
		CentLeft = GameObject.Find ("CentLeft");
		CentUp = GameObject.Find ("CentUp");
		CentDown = GameObject.Find ("CentDown");

		SpigFrontUp = GameObject.Find ("SpigFrontUp");
		SpigFrontLeft = GameObject.Find ("SpigFrontLeft");
		SpigFrontRight = GameObject.Find ("SpigFrontRight");
		SpigFrontDown = GameObject.Find ("SpigFrontDown");
		SpigBackUp = GameObject.Find ("SpigBackUp");
		SpigBackLeft = GameObject.Find ("SpigBackLeft");
		SpigBackRight = GameObject.Find ("SpigBackRight");
		SpigBackDown = GameObject.Find ("SpigBackDown");
		SpigRightUp = GameObject.Find ("SpigRightUp");
		SpigRightLeft = GameObject.Find ("SpigRightLeft");
		SpigRightRight = GameObject.Find ("SpigRightRight");
		SpigRightDown = GameObject.Find ("SpigRightDown");
		SpigLeftUp = GameObject.Find ("SpigLeftUp");
		SpigLeftLeft = GameObject.Find ("SpigLeftLeft");
		SpigLeftRight = GameObject.Find ("SpigLeftRight");
		SpigLeftDown = GameObject.Find ("SpigLeftDown");
		SpigUpUp = GameObject.Find ("SpigUpUp");
		SpigUpLeft = GameObject.Find ("SpigUpLeft");
		SpigUpRight = GameObject.Find ("SpigUpRight");
		SpigUpDown = GameObject.Find ("SpigUpDown");
		SpigDownUp = GameObject.Find ("SpigDownUp");
		SpigDownLeft = GameObject.Find ("SpigDownLeft");
		SpigDownRight = GameObject.Find ("SpigDownRight");
		SpigDownDown = GameObject.Find ("SpigDownDown");

		VertFrontRightUp = GameObject.Find ("VertFrontRightUp");
		VertFrontRightDown = GameObject.Find ("VertFrontRightDown");
		VertFrontLeftUp = GameObject.Find ("VertFrontLeftUp");
		VertFrontLeftDown = GameObject.Find ("VertFrontLeftDown");
		VertBackRightUp = GameObject.Find ("VertBackRightUp");
		VertBackRightDown = GameObject.Find ("VertBackRightDown");
		VertBackLeftUp = GameObject.Find ("VertBackLeftUp");
		VertBackLeftDown = GameObject.Find ("VertBackLeftDown");
		VertLeftRightUp = GameObject.Find ("VertLeftRightUp");
		VertLeftRightDown = GameObject.Find ("VertLeftRightDown");
		VertLeftLeftUp = GameObject.Find ("VertLeftLeftUp");
		VertLeftLeftDown = GameObject.Find ("VertLeftLeftDown");
		VertRightRightUp = GameObject.Find ("VertRightRightUp");
		VertRightRightDown = GameObject.Find ("VertRightRightDown");
		VertRightLeftUp = GameObject.Find ("VertRightLeftUp");
		VertRightLeftDown = GameObject.Find ("VertRightLeftDown");
		VertUpRightUp = GameObject.Find ("VertUpRightUp");
		VertUpRightDown = GameObject.Find ("VertUpRightDown");
		VertUpLeftUp = GameObject.Find ("VertUpLeftUp");
		VertUpLeftDown = GameObject.Find ("VertUpLeftDown");
		VertDownRightUp = GameObject.Find ("VertDownRightUp");
		VertDownRightDown = GameObject.Find ("VertDownRightDown");
		VertDownLeftUp = GameObject.Find ("VertDownLeftUp");
		VertDownLeftDown = GameObject.Find ("VertDownLeftDown");

		AggiornaColori ();

		mFase1Completata = false;
		mFase2Completata = false;
		mFase3Completata = false;
		mFase4Completata = false;
		mFase5Completata = false;
		mFase6Completata = false;
		mFase7Completata = false;
		mFase8Completata = false;

		mFase2RossoOK = false;
		mFase2BluOK = false;
		mFase2ArancioneOK = false;
		mFase2VerdeOK = false;
	}

	protected void AggiornaColori () {
		mBianco = CentUp.GetComponent<Renderer> ().material.color;
		mRosso = CentFront.GetComponent<Renderer> ().material.color;
		mBlu = CentRight.GetComponent<Renderer> ().material.color;
		mVerde = CentLeft.GetComponent<Renderer> ().material.color;
		mArancione = CentBack.GetComponent<Renderer> ().material.color;
		mGiallo = CentDown.GetComponent<Renderer> ().material.color;

		CentFrontColor = CentFront.GetComponent<Renderer> ().material.color;
		CentBackColor = CentBack.GetComponent<Renderer> ().material.color;
		CentRightColor = CentRight.GetComponent<Renderer> ().material.color;
		CentLeftColor = CentLeft.GetComponent<Renderer> ().material.color;
		CentUpColor = CentUp.GetComponent<Renderer> ().material.color;
		CentDownColor = CentDown.GetComponent<Renderer> ().material.color;

		SpigFrontUpColor = SpigFrontUp.GetComponent<Renderer> ().material.color;
		SpigFrontLeftColor = SpigFrontLeft.GetComponent<Renderer> ().material.color;
		SpigFrontRightColor = SpigFrontRight.GetComponent<Renderer> ().material.color;
		SpigFrontDownColor = SpigFrontDown.GetComponent<Renderer> ().material.color;
		SpigBackUpColor = SpigBackUp.GetComponent<Renderer> ().material.color;
		SpigBackLeftColor = SpigBackLeft.GetComponent<Renderer> ().material.color;
		SpigBackRightColor = SpigBackRight.GetComponent<Renderer> ().material.color;
		SpigBackDownColor = SpigBackDown.GetComponent<Renderer> ().material.color;
		SpigRightUpColor = SpigRightUp.GetComponent<Renderer> ().material.color;
		SpigRightLeftColor = SpigRightLeft.GetComponent<Renderer> ().material.color;
		SpigRightRightColor = SpigRightRight.GetComponent<Renderer> ().material.color;
		SpigRightDownColor = SpigRightDown.GetComponent<Renderer> ().material.color;
		SpigLeftUpColor = SpigLeftUp.GetComponent<Renderer> ().material.color;
		SpigLeftLeftColor = SpigLeftLeft.GetComponent<Renderer> ().material.color;
		SpigLeftRightColor = SpigLeftRight.GetComponent<Renderer> ().material.color;
		SpigLeftDownColor = SpigLeftDown.GetComponent<Renderer> ().material.color;
		SpigUpUpColor = SpigUpUp.GetComponent<Renderer> ().material.color;
		SpigUpLeftColor = SpigUpLeft.GetComponent<Renderer> ().material.color;
		SpigUpRightColor = SpigUpRight.GetComponent<Renderer> ().material.color;
		SpigUpDownColor = SpigUpDown.GetComponent<Renderer> ().material.color;
		SpigDownUpColor = SpigDownUp.GetComponent<Renderer> ().material.color;
		SpigDownLeftColor = SpigDownLeft.GetComponent<Renderer> ().material.color;
		SpigDownRightColor = SpigDownRight.GetComponent<Renderer> ().material.color;
		SpigDownDownColor = SpigDownDown.GetComponent<Renderer> ().material.color;

		VertFrontRightUpColor = VertFrontRightUp.GetComponent<Renderer> ().material.color;
		VertFrontRightDownColor = VertFrontRightDown.GetComponent<Renderer> ().material.color;
		VertFrontLeftUpColor = VertFrontLeftUp.GetComponent<Renderer> ().material.color;
		VertFrontLeftDownColor = VertFrontLeftDown.GetComponent<Renderer> ().material.color;
		VertBackRightUpColor = VertBackRightUp.GetComponent<Renderer> ().material.color;
		VertBackRightDownColor = VertBackRightDown.GetComponent<Renderer> ().material.color;
		VertBackLeftUpColor = VertBackLeftUp.GetComponent<Renderer> ().material.color;
		VertBackLeftDownColor = VertBackLeftDown.GetComponent<Renderer> ().material.color;
		VertLeftRightUpColor = VertLeftRightUp.GetComponent<Renderer> ().material.color;
		VertLeftRightDownColor = VertLeftRightDown.GetComponent<Renderer> ().material.color;
		VertLeftLeftUpColor = VertLeftLeftUp.GetComponent<Renderer> ().material.color;
		VertLeftLeftDownColor = VertLeftLeftDown.GetComponent<Renderer> ().material.color;
		VertRightRightUpColor = VertRightRightUp.GetComponent<Renderer> ().material.color;
		VertRightRightDownColor = VertRightRightDown.GetComponent<Renderer> ().material.color;
		VertRightLeftUpColor = VertRightLeftUp.GetComponent<Renderer> ().material.color;
		VertRightLeftDownColor = VertRightLeftDown.GetComponent<Renderer> ().material.color;
		VertUpRightUpColor = VertUpRightUp.GetComponent<Renderer> ().material.color;
		VertUpRightDownColor = VertUpRightDown.GetComponent<Renderer> ().material.color;
		VertUpLeftUpColor = VertUpLeftUp.GetComponent<Renderer> ().material.color;
		VertUpLeftDownColor = VertUpLeftDown.GetComponent<Renderer> ().material.color;
		VertDownRightUpColor = VertDownRightUp.GetComponent<Renderer> ().material.color;
		VertDownRightDownColor = VertDownRightDown.GetComponent<Renderer> ().material.color;
		VertDownLeftUpColor = VertDownLeftUp.GetComponent<Renderer> ().material.color;
		VertDownLeftDownColor = VertDownLeftDown.GetComponent<Renderer> ().material.color;
	}

	// Update is called once per frame
	void Update () {
		if (mRisolvi && mGameManager.IsGameRunning () && mAnimatore.isFermoAnimatorePuoAndare () && Fase8Completata ()) {			//Controllo se il cubo è risolto
			AggiornaColori();
			mGameManager.ControllaSeHoVinto ();
			Reset ();
		}

		if (mRisolvi && mGameManager.IsGameRunning () && mAnimatore.isFermoAnimatorePuoAndare ()) {
			AggiornaColori ();
			if (!mFase1Completata) {																				//FASE 1
				if (mGameManager.ColorCompare(SpigUpRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 7 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigUpUpColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 3 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigUpLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5, 5 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigUpDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1, 1 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigFrontLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigRightLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigBackLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigLeftLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigFrontRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 8 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigRightRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 4 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigBackRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 6 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigLeftRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 2 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigFrontUpColor, mBianco) || mGameManager.ColorCompare(SpigFrontDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigRightUpColor, mBianco) || mGameManager.ColorCompare(SpigRightDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigBackUpColor, mBianco) || mGameManager.ColorCompare(SpigBackDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigLeftUpColor, mBianco) || mGameManager.ColorCompare(SpigLeftDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else {
					mFase1Completata = true;
				}
			} else if (!mFase2Completata) {																		//FASE 2
				if (!mFase2RossoOK && mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 1 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (2);
					mFase2RossoOK = true;
				} else if (!mFase2RossoOK && !(mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mGameManager.HoFattoUnaMossa ();
				} else if (!mFase2BluOK && mGameManager.ColorCompare(SpigRightDownColor, mBlu) && mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 7 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (2);
					mFase2BluOK = true;
				} else if (!mFase2BluOK && !(mGameManager.ColorCompare(SpigRightDownColor, mBlu) && mGameManager.ColorCompare(SpigDownRightColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mGameManager.HoFattoUnaMossa ();
				} else if (!mFase2ArancioneOK && mGameManager.ColorCompare(SpigBackDownColor, mArancione) && mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 3 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (2);
					mFase2ArancioneOK = true;
				} else if (!mFase2ArancioneOK && !(mGameManager.ColorCompare(SpigBackDownColor, mArancione) && mGameManager.ColorCompare(SpigDownDownColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mGameManager.HoFattoUnaMossa ();
				} else if (!mFase2VerdeOK && mGameManager.ColorCompare(SpigLeftDownColor, mVerde) && mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 5 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (2);
					mFase2VerdeOK = true;
				} else if (!mFase2VerdeOK && !(mGameManager.ColorCompare(SpigLeftDownColor, mVerde) && mGameManager.ColorCompare(SpigDownLeftColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mGameManager.HoFattoUnaMossa ();
				} else {
					mFase2Completata = true;
				}
			} else if (!mFase3Completata) {																		//FASE 3
				if (!Fase3SuperioriOK ()) {																			//Parte 1 - Controllo superiori
					if (mGameManager.ColorCompare(VertDownLeftUpColor, mBianco)) {			
						if (mGameManager.ColorCompare(VertLeftRightDownColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (8);
						} else if (mGameManager.ColorCompare(VertLeftRightDownColor, mBlu)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (9);
						} else if (mGameManager.ColorCompare(VertLeftRightDownColor, mArancione)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (10);
						} else if (mGameManager.ColorCompare(VertLeftRightDownColor, mVerde)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (9);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3FrontaliOK ()) {																			//Parte 2 - Controllo frontali
					if (mGameManager.ColorCompare(VertFrontLeftDownColor, mBianco)) {		
						if (mGameManager.ColorCompare(VertDownLeftUpColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 2, 12, 1 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (3);
						}else if (mGameManager.ColorCompare(VertDownLeftUpColor, mBlu)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 8, 12, 7 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (4);
						}else if (mGameManager.ColorCompare(VertDownLeftUpColor, mArancione)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 4, 12, 3 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (5);
						}else if (mGameManager.ColorCompare(VertDownLeftUpColor, mVerde)){
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 6, 12, 5 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (4);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3LateraliOK ()) {																				//Parte 3 - Controllo laterali
					if (mGameManager.ColorCompare(VertLeftRightDownColor, mBianco)) {
						if (mGameManager.ColorCompare(VertFrontLeftDownColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (3);
						} else if (mGameManager.ColorCompare(VertFrontLeftDownColor, mBlu)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 2 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (4);
						} else if (mGameManager.ColorCompare(VertFrontLeftDownColor, mArancione)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 8 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (5);
						} else if (mGameManager.ColorCompare(VertFrontLeftDownColor, mVerde)){
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 4 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (4);
						}
					} else {
							mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
							mGameManager.HoFattoUnaMossa ();
					} 
				} else if (mGameManager.ColorCompare(VertFrontLeftUpColor, mBianco) || mGameManager.ColorCompare(VertLeftRightUpColor, mBianco)) {  //Parte 4 - Controllo se alcuni sono sotto
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (mGameManager.ColorCompare(VertRightLeftUpColor, mBianco) || mGameManager.ColorCompare(VertFrontRightUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (mGameManager.ColorCompare(VertBackLeftUpColor, mBianco) || mGameManager.ColorCompare(VertRightRightUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (mGameManager.ColorCompare(VertLeftLeftUpColor, mBianco) || mGameManager.ColorCompare(VertBackRightUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertFrontLeftUpColor, mRosso)) {  																				//Parte 5 - Controllo se posizioni sbagliate: bianco giusto, lati sbagliati
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertRightLeftUpColor, mBlu)) {  
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertBackLeftUpColor, mArancione)) {  
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertLeftLeftUpColor, mVerde)) {  
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (3);
				} else {
					if (Fase3PavimentoBiancoCompletato ()) {
						mFase3Completata = true;
					}
				}
			} else if(!mFase4Completata){																																			//FASE 4
				if (mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mVerde)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mVerde) && mGameManager.ColorCompare(SpigDownUpColor, mArancione)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (7);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mArancione) && mGameManager.ColorCompare(SpigDownUpColor, mBlu)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mBlu) && mGameManager.ColorCompare(SpigDownUpColor, mRosso)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (9);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mBlu)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mBlu) && mGameManager.ColorCompare(SpigDownUpColor, mArancione)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (7);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mArancione) && mGameManager.ColorCompare(SpigDownUpColor, mVerde)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mVerde) && mGameManager.ColorCompare(SpigDownUpColor, mRosso)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (9);

				} else if (!Fase4Completata () && Fase4PossoContinuareAGirareSuperiore ()) {
					
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mGameManager.HoFattoUnaMossa ();

				} else if(!Fase4Completata()){
					
					if (!mGameManager.ColorCompare(SpigFrontRightColor, mGiallo) && !mGameManager.ColorCompare(SpigFrontRightColor, mRosso) && !mGameManager.ColorCompare(SpigRightLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigRightLeftColor, mBlu)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (7);
					} else if (!mGameManager.ColorCompare(SpigRightRightColor, mGiallo) && !mGameManager.ColorCompare(SpigRightRightColor, mBlu) && !mGameManager.ColorCompare(SpigBackLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigBackLeftColor, mArancione)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (7);
					} else if (!mGameManager.ColorCompare(SpigBackRightColor, mGiallo) && !mGameManager.ColorCompare(SpigBackRightColor, mArancione) && !mGameManager.ColorCompare(SpigLeftLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigLeftLeftColor, mVerde)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (7);
					} else if (!mGameManager.ColorCompare(SpigLeftRightColor, mGiallo) && !mGameManager.ColorCompare(SpigLeftRightColor, mVerde) && !mGameManager.ColorCompare(SpigFrontLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigFrontLeftColor, mRosso)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (7);
					}

				} else{
					mFase4Completata = true;
				}
			} else if(!mFase5Completata){																																			//FASE 5
				if (mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else if (mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 3, 12, 4, 6 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 11, 5, 12, 6, 2 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 1, 12, 2, 8 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 7, 11, 8, 12, 4 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else if (mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 3, 11, 4, 12, 6 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (6);
				} else {
					mFase5Completata = true;
				}
			} else if (!mFase6Completata){																																			//FASE 6
				if(Fase6UnoAcceso()){	//Croce + basso sinistra
					if (mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (8);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (!mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo)){ //Croce
					if (mGameManager.ColorCompare(VertLeftRightDownColor, mGiallo) && mGameManager.ColorCompare(VertLeftLeftDownColor, mGiallo)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (8);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (Fase6TSpessa()){ //T spessa punta giu
					if (!mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) {
						if (mGameManager.ColorCompare(VertBackLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertBackRightDownColor, mGiallo)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (8);
						} else {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (9);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)){ //Quadrati intersecati giusti
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (8);
				} else if (!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)){ //Quadrati intersecati sbagliati
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (9);
				} else {
					mFase6Completata = true;
				}
			} else if (!mFase7Completata){																																			//FASE 7
				if (!Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					if (mGameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor)) {
						if (mGameManager.ColorCompare(VertFrontLeftDownColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (12);
						} else if(mGameManager.ColorCompare(VertFrontLeftDownColor, mVerde)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (13);
						} else if(mGameManager.ColorCompare(VertFrontLeftDownColor, mArancione)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (14);
						} else if(mGameManager.ColorCompare(VertFrontLeftDownColor, mBlu)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 1, 6, 1, 7, 7, 2, 5, 1, 7, 7, 1, 1 }, mVelocitaEsecuzione);
							mGameManager.HoFattoPiuMosse (13);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, mVelocitaEsecuzione);
					mGameManager.HoFattoPiuMosse (12);
				} else {
					mFase7Completata = true;
				}
			} else if (!mFase8Completata){																																			//FASE 8
				if (!Fase8Completata ()) {
					if(Fase8NonCiSonoLineeComplete()){
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (12);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(VertFrontLeftDownColor, mRosso) && mGameManager.ColorCompare(VertFrontRightDownColor, mRosso)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (12);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mVerde) && mGameManager.ColorCompare(VertFrontLeftDownColor, mVerde) && mGameManager.ColorCompare(VertFrontRightDownColor, mVerde)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7}, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (13);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mArancione) && mGameManager.ColorCompare(VertFrontLeftDownColor, mArancione) && mGameManager.ColorCompare(VertFrontRightDownColor, mArancione)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1}, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (14);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mBlu) && mGameManager.ColorCompare(VertFrontLeftDownColor, mBlu) && mGameManager.ColorCompare(VertFrontRightDownColor, mBlu)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 11, 5, 5, 12, 4, 1, 5, 5, 3, 2, 12, 5, 5}, mVelocitaEsecuzione);
						mGameManager.HoFattoPiuMosse (13);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mGameManager.HoFattoUnaMossa ();
					}
				} else {
					mFase8Completata = true;
				}
			} else {
				Reset ();
			}
		}
	}

	public bool Fase1QuattroBiachiConGialloInMezzo(){  	//Condizione fine fase 1
		return 	
			mGameManager.ColorCompare(SpigDownUpColor, mBianco) &&
			mGameManager.ColorCompare(SpigDownLeftColor, mBianco) && 
			mGameManager.ColorCompare(SpigDownDownColor, mBianco) &&
			mGameManager.ColorCompare(SpigDownRightColor, mBianco);
	}

	public bool Fase2CroceBiancaCompletata(){			//Condizione fine fase 2
		return
			mGameManager.ColorCompare(SpigUpUpColor, mBianco) &&
			mGameManager.ColorCompare(SpigUpLeftColor, mBianco) && 
			mGameManager.ColorCompare(SpigUpDownColor, mBianco) &&
			mGameManager.ColorCompare(SpigUpRightColor, mBianco) &&
			mGameManager.ColorCompare(SpigFrontUpColor, mRosso) &&
			mGameManager.ColorCompare(SpigRightUpColor, mBlu) &&
			mGameManager.ColorCompare(SpigBackUpColor, mArancione) &&
			mGameManager.ColorCompare(SpigLeftUpColor, mVerde);
	}

	public bool Fase3PavimentoBiancoCompletato(){		//Condizione fine fase 3
		return 
			mGameManager.ColorCompare(SpigUpUpColor, mBianco) &&
			mGameManager.ColorCompare(SpigUpLeftColor, mBianco) && 
			mGameManager.ColorCompare(SpigUpDownColor, mBianco) &&
			mGameManager.ColorCompare(SpigUpRightColor, mBianco) &&
			mGameManager.ColorCompare(VertUpLeftUpColor, mBianco) &&
			mGameManager.ColorCompare(VertUpLeftDownColor, mBianco) &&
			mGameManager.ColorCompare(VertUpRightUpColor, mBianco) &&
			mGameManager.ColorCompare(VertUpRightDownColor, mBianco);
	}

	public bool Fase3FrontaliOK(){
		return
			!mGameManager.ColorCompare(VertFrontLeftDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertLeftLeftDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertBackLeftDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertRightLeftDownColor, mBianco);

	}

	public bool Fase3LateraliOK(){
		return
			!mGameManager.ColorCompare(VertLeftRightDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertFrontRightDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertRightRightDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertBackRightDownColor, mBianco);

	}

	public bool Fase3SuperioriOK(){
		return
			!mGameManager.ColorCompare(VertDownLeftUpColor, mBianco) &&
			!mGameManager.ColorCompare(VertDownLeftDownColor, mBianco) &&
			!mGameManager.ColorCompare(VertDownRightUpColor, mBianco) &&
			!mGameManager.ColorCompare(VertDownRightDownColor, mBianco);

	}

	public bool Fase4Completata(){							//Condizione fine fase 4
		return
			mGameManager.ColorCompare(SpigFrontLeftColor, mRosso) &&
			mGameManager.ColorCompare(SpigFrontRightColor, mRosso) &&
			mGameManager.ColorCompare(SpigLeftLeftColor, mVerde) &&
			mGameManager.ColorCompare(SpigLeftRightColor, mVerde) &&
			mGameManager.ColorCompare(SpigRightLeftColor, mBlu) &&
			mGameManager.ColorCompare(SpigRightRightColor, mBlu) &&
			mGameManager.ColorCompare(SpigBackLeftColor, mArancione) &&
			mGameManager.ColorCompare(SpigBackRightColor, mArancione);
	}

	public bool Fase4PossoContinuareAGirareSuperiore(){
		return
			(!mGameManager.ColorCompare(SpigFrontDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownUpColor, mGiallo)) ||
			(!mGameManager.ColorCompare(SpigRightDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo)) ||
			(!mGameManager.ColorCompare(SpigBackDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo)) ||
			(!mGameManager.ColorCompare(SpigLeftDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo));
	}

	public bool Fase5Completata(){							//Condizione fine fase 5
		return
			mGameManager.ColorCompare(SpigDownLeftColor, mGiallo) &&
			mGameManager.ColorCompare(SpigDownUpColor, mGiallo) &&
			mGameManager.ColorCompare(SpigDownRightColor, mGiallo) &&
			mGameManager.ColorCompare(SpigDownDownColor, mGiallo);
	}

	public bool Fase6UnoAcceso(){
		return
			(mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) ||
			(!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) ||
			(!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) ||
			(!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertDownRightDownColor, mGiallo));
	}

	public bool Fase6TSpessa(){
		return
			(mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) ||
			(!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) ||
			(!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) ||
			(mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo));
	}

	public bool Fase6Completata(){							//Condizione fine fase 6
		return
			mGameManager.ColorCompare(SpigDownLeftColor, mGiallo) &&
			mGameManager.ColorCompare(SpigDownUpColor, mGiallo) &&
			mGameManager.ColorCompare(SpigDownRightColor, mGiallo) &&
			mGameManager.ColorCompare(SpigDownDownColor, mGiallo) &&
			mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) &&
			mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) &&
			mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) &&
			mGameManager.ColorCompare(VertDownRightDownColor, mGiallo);
	}

	public bool Fase7TuttiDiversi(){
		return
			!mGameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor) &&
			!mGameManager.ColorCompare(VertLeftLeftDownColor, VertLeftRightDownColor) &&
			!mGameManager.ColorCompare(VertBackLeftDownColor, VertBackRightDownColor) &&
			!mGameManager.ColorCompare(VertRightLeftDownColor, VertRightRightDownColor);
	}

	public bool Fase7TuttiUguali(){							//Condizione fine fase 7
		return
			mGameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor) &&
			mGameManager.ColorCompare(VertLeftLeftDownColor, VertLeftRightDownColor) &&
			mGameManager.ColorCompare(VertBackLeftDownColor, VertBackRightDownColor) &&
			mGameManager.ColorCompare(VertRightLeftDownColor, VertRightRightDownColor);
	}

	public bool Fase8NonCiSonoLineeComplete(){
		return
			!mGameManager.ColorCompare(VertFrontLeftDownColor, SpigFrontDownColor) &&
			!mGameManager.ColorCompare(VertRightLeftDownColor, SpigRightDownColor) &&
			!mGameManager.ColorCompare(VertBackLeftDownColor, SpigBackDownColor) &&
			!mGameManager.ColorCompare(VertLeftLeftDownColor, SpigLeftDownColor);
	}

	public bool Fase8Completata(){							//Condizione fine fase 7
		return mStatoCubo.IsStatoIniziale();
	}



	public void Risolvi(){
		mRisolvi = true;
		mGameManager.ResetMosseEseguite ();
		mStatistiche.TimeReset ();
		mAnimatore.SetStatoStoRisolvendo (true);
	}

	public void Reset(){
		mFase1Completata = false;
		mFase2Completata = false;
		mFase3Completata = false;
		mFase4Completata = false;
		mFase5Completata = false;
		mFase6Completata = false;
		mFase7Completata = false;
		mFase8Completata = false;

		mFase2RossoOK = false;
		mFase2BluOK = false;
		mFase2ArancioneOK = false;
		mFase2VerdeOK = false;

		mRisolvi = false;
		mAnimatore.SetStatoStoRisolvendo (false);
	}
}
