using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_HelpMe : AI {

	[SerializeField]
	private HelpMeTutor mHelpMeTutor;

	void Update () {

		if (mRisolvi && mGameManager.IsGameRunning () && mAnimatore.isFermoAnimatorePuoAndare () && mGameManager.GetNumMosseEseguite () >= 300) {
			Reset ();
			FileManager.caricaDaFile ();
			FileManager.setFilename ("saveFile");
			mHelpMeTutor.FineCalcolo (false);
		}

		if (mRisolvi && mGameManager.IsGameRunning () && mAnimatore.isFermoAnimatorePuoAndare () && Fase8Completata ()) {			//Controllo se il cubo è risolto
			AggiornaColori();
			mGameManager.ControllaSeHoVinto ();
			Reset ();
			int mosseEseguiteTemp = mGameManager.GetNumMosseEseguite ();
			FileManager.caricaDaFile ();
			FileManager.setFilename ("saveFile");
			mGameManager.HoFattoPiuMosse (mosseEseguiteTemp);
			mHelpMeTutor.FineCalcolo (true);
		}

		if (mRisolvi && mGameManager.IsGameRunning () && mAnimatore.isFermoAnimatorePuoAndare ()) {
			AggiornaColori ();
			if (!mFase1Completata) {																				//FASE 1
				if (mGameManager.ColorCompare(SpigUpRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 7 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 7, 7 });
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigUpUpColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 3 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 3, 3 });
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigUpLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5, 5 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 5, 5 });
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigUpDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1, 1 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 1, 1 });
						mGameManager.HoFattoPiuMosse (2);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigFrontLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 5 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigRightLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 1 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigBackLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 7 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigLeftLeftColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 3 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigFrontRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 8 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 8 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigRightRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 4 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 4 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigBackRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 6 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 6 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigLeftRightColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 2 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 2 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigFrontUpColor, mBianco) || mGameManager.ColorCompare(SpigFrontDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 1 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigRightUpColor, mBianco) || mGameManager.ColorCompare(SpigRightDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 7 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigBackUpColor, mBianco) || mGameManager.ColorCompare(SpigBackDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 3 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(SpigLeftUpColor, mBianco) || mGameManager.ColorCompare(SpigLeftDownColor, mBianco)) {
					if (!mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 5 });
						mGameManager.HoFattoUnaMossa ();
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else {
					mFase1Completata = true;
				}
			} else if (!mFase2Completata) {																		//FASE 2
				if (!mFase2RossoOK && mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 1 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 1, 1 });
					mGameManager.HoFattoPiuMosse (2);
					mFase2RossoOK = true;
				} else if (!mFase2RossoOK && !(mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
					mGameManager.HoFattoUnaMossa ();
				} else if (!mFase2BluOK && mGameManager.ColorCompare(SpigRightDownColor, mBlu) && mGameManager.ColorCompare(SpigDownRightColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 7 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 7, 7 });
					mGameManager.HoFattoPiuMosse (2);
					mFase2BluOK = true;
				} else if (!mFase2BluOK && !(mGameManager.ColorCompare(SpigRightDownColor, mBlu) && mGameManager.ColorCompare(SpigDownRightColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
					mGameManager.HoFattoUnaMossa ();
				} else if (!mFase2ArancioneOK && mGameManager.ColorCompare(SpigBackDownColor, mArancione) && mGameManager.ColorCompare(SpigDownDownColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 3 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 3 });
					mGameManager.HoFattoPiuMosse (2);
					mFase2ArancioneOK = true;
				} else if (!mFase2ArancioneOK && !(mGameManager.ColorCompare(SpigBackDownColor, mArancione) && mGameManager.ColorCompare(SpigDownDownColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
					mGameManager.HoFattoUnaMossa ();
				} else if (!mFase2VerdeOK && mGameManager.ColorCompare(SpigLeftDownColor, mVerde) && mGameManager.ColorCompare(SpigDownLeftColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 5 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 5, 5 });
					mGameManager.HoFattoPiuMosse (2);
					mFase2VerdeOK = true;
				} else if (!mFase2VerdeOK && !(mGameManager.ColorCompare(SpigLeftDownColor, mVerde) && mGameManager.ColorCompare(SpigDownLeftColor, mBianco))) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
					mGameManager.HoFattoUnaMossa ();
				} else {
					mFase2Completata = true;
				}
			} else if (!mFase3Completata) {																		//FASE 3
				if (!Fase3SuperioriOK ()) {																			//Parte 1 - Controllo superiori
					if (mGameManager.ColorCompare(VertDownLeftUpColor, mBianco)) {			
						if (mGameManager.ColorCompare(VertLeftRightDownColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 });
							mGameManager.HoFattoPiuMosse (8);
						} else if (mGameManager.ColorCompare(VertLeftRightDownColor, mBlu)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 });
							mGameManager.HoFattoPiuMosse (9);
						} else if (mGameManager.ColorCompare(VertLeftRightDownColor, mArancione)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 });
							mGameManager.HoFattoPiuMosse (10);
						} else if (mGameManager.ColorCompare(VertLeftRightDownColor, mVerde)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 });
							mGameManager.HoFattoPiuMosse (9);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3FrontaliOK ()) {																			//Parte 2 - Controllo frontali
					if (mGameManager.ColorCompare(VertFrontLeftDownColor, mBianco)) {		
						if (mGameManager.ColorCompare(VertDownLeftUpColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 2, 12, 1 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 2, 12, 1 });
							mGameManager.HoFattoPiuMosse (3);
						}else if (mGameManager.ColorCompare(VertDownLeftUpColor, mBlu)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 8, 12, 7 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 8, 12, 7 });
							mGameManager.HoFattoPiuMosse (4);
						}else if (mGameManager.ColorCompare(VertDownLeftUpColor, mArancione)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 4, 12, 3 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 4, 12, 3 });
							mGameManager.HoFattoPiuMosse (5);
						}else if (mGameManager.ColorCompare(VertDownLeftUpColor, mVerde)){
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 6, 12, 5 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 12, 6, 12, 5 });
							mGameManager.HoFattoPiuMosse (4);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3LateraliOK ()) {																				//Parte 3 - Controllo laterali
					if (mGameManager.ColorCompare(VertLeftRightDownColor, mBianco)) {
						if (mGameManager.ColorCompare(VertFrontLeftDownColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 6 });
							mGameManager.HoFattoPiuMosse (3);
						} else if (mGameManager.ColorCompare(VertFrontLeftDownColor, mBlu)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 2 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 1, 11, 2 });
							mGameManager.HoFattoPiuMosse (4);
						} else if (mGameManager.ColorCompare(VertFrontLeftDownColor, mArancione)){
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 8 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 7, 11, 8 });
							mGameManager.HoFattoPiuMosse (5);
						} else if (mGameManager.ColorCompare(VertFrontLeftDownColor, mVerde)){
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 4 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 12, 3, 11, 4 });
							mGameManager.HoFattoPiuMosse (4);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					} 
				} else if (mGameManager.ColorCompare(VertFrontLeftUpColor, mBianco) || mGameManager.ColorCompare(VertLeftRightUpColor, mBianco)) {  //Parte 4 - Controllo se alcuni sono sotto
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 6 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (mGameManager.ColorCompare(VertRightLeftUpColor, mBianco) || mGameManager.ColorCompare(VertFrontRightUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 1, 11, 2 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (mGameManager.ColorCompare(VertBackLeftUpColor, mBianco) || mGameManager.ColorCompare(VertRightRightUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (mGameManager.ColorCompare(VertLeftLeftUpColor, mBianco) || mGameManager.ColorCompare(VertBackRightUpColor, mBianco)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 4 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertFrontLeftUpColor, mRosso)) {  																				//Parte 5 - Controllo se posizioni sbagliate: bianco giusto, lati sbagliati
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 6 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertRightLeftUpColor, mBlu)) {  
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 1, 11, 2 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertBackLeftUpColor, mArancione)) {  
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8 });
					mGameManager.HoFattoPiuMosse (3);
				} else if (!mGameManager.ColorCompare(VertLeftLeftUpColor, mVerde)) {  
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 4 });
					mGameManager.HoFattoPiuMosse (3);
				} else {
					if (Fase3PavimentoBiancoCompletato ()) {
						mFase3Completata = true;
					}
				}
			} else if(!mFase4Completata){																																			//FASE 4
				if (mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mVerde)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 });
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mVerde) && mGameManager.ColorCompare(SpigDownUpColor, mArancione)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 });
					mGameManager.HoFattoPiuMosse (7);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mArancione) && mGameManager.ColorCompare(SpigDownUpColor, mBlu)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 });
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mBlu) && mGameManager.ColorCompare(SpigDownUpColor, mRosso)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 });
					mGameManager.HoFattoPiuMosse (9);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(SpigDownUpColor, mBlu)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 });
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mBlu) && mGameManager.ColorCompare(SpigDownUpColor, mArancione)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 });
					mGameManager.HoFattoPiuMosse (7);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mArancione) && mGameManager.ColorCompare(SpigDownUpColor, mVerde)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 });
					mGameManager.HoFattoPiuMosse (8);
				} else if (mGameManager.ColorCompare(SpigFrontDownColor, mVerde) && mGameManager.ColorCompare(SpigDownUpColor, mRosso)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 });
					mGameManager.HoFattoPiuMosse (9);

				} else if (!Fase4Completata () && Fase4PossoContinuareAGirareSuperiore ()) {

					mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
					mGameManager.HoFattoUnaMossa ();

				} else if(!Fase4Completata()){

					if (!mGameManager.ColorCompare(SpigFrontRightColor, mGiallo) && !mGameManager.ColorCompare(SpigFrontRightColor, mRosso) && !mGameManager.ColorCompare(SpigRightLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigRightLeftColor, mBlu)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 });
						mGameManager.HoFattoPiuMosse (7);
					} else if (!mGameManager.ColorCompare(SpigRightRightColor, mGiallo) && !mGameManager.ColorCompare(SpigRightRightColor, mBlu) && !mGameManager.ColorCompare(SpigBackLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigBackLeftColor, mArancione)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 });
						mGameManager.HoFattoPiuMosse (7);
					} else if (!mGameManager.ColorCompare(SpigBackRightColor, mGiallo) && !mGameManager.ColorCompare(SpigBackRightColor, mArancione) && !mGameManager.ColorCompare(SpigLeftLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigLeftLeftColor, mVerde)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 });
						mGameManager.HoFattoPiuMosse (7);
					} else if (!mGameManager.ColorCompare(SpigLeftRightColor, mGiallo) && !mGameManager.ColorCompare(SpigLeftRightColor, mVerde) && !mGameManager.ColorCompare(SpigFrontLeftColor, mGiallo) && !mGameManager.ColorCompare(SpigFrontLeftColor, mRosso)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 });
						mGameManager.HoFattoPiuMosse (7);
					}

				} else{
					mFase4Completata = true;
				}
			} else if(!mFase5Completata){																																			//FASE 5
				if (mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 7, 12, 8, 4 });
					mGameManager.HoFattoPiuMosse (6);
				} else if (mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 11, 3, 12, 4, 6 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 3, 12, 4, 6 });
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 1, 11, 5, 12, 6, 2 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 1, 11, 5, 12, 6, 2 });
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 1, 12, 2, 8 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 1, 12, 2, 8 });
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 7, 11, 8, 12, 4 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 7, 11, 8, 12, 4 });
					mGameManager.HoFattoPiuMosse (6);
				} else if (mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 5, 3, 11, 4, 12, 6 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 5, 3, 11, 4, 12, 6 });
					mGameManager.HoFattoPiuMosse (6);
				} else if (!mGameManager.ColorCompare(SpigDownUpColor, mGiallo) && !mGameManager.ColorCompare(SpigDownRightColor, mGiallo) && !mGameManager.ColorCompare(SpigDownDownColor, mGiallo) && !mGameManager.ColorCompare(SpigDownLeftColor, mGiallo)) {
					mAnimatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 7, 12, 8, 4 });
					mGameManager.HoFattoPiuMosse (6);
				} else {
					mFase5Completata = true;
				}
			} else if (!mFase6Completata){																																			//FASE 6
				if(Fase6UnoAcceso()){	//Croce + basso sinistra
					if (mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
						mGameManager.HoFattoPiuMosse (8);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (!mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo)){ //Croce
					if (mGameManager.ColorCompare(VertLeftRightDownColor, mGiallo) && mGameManager.ColorCompare(VertLeftLeftDownColor, mGiallo)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
						mGameManager.HoFattoPiuMosse (8);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (Fase6TSpessa()){ //T spessa punta giu
					if (!mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)) {
						if (mGameManager.ColorCompare(VertBackLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertBackRightDownColor, mGiallo)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
							mGameManager.HoFattoPiuMosse (8);
						} else {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 });
							mGameManager.HoFattoPiuMosse (9);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && !mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)){ //Quadrati intersecati giusti
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
					mGameManager.HoFattoPiuMosse (8);
				} else if (!mGameManager.ColorCompare(VertDownLeftUpColor, mGiallo) && mGameManager.ColorCompare(VertDownRightUpColor, mGiallo) && mGameManager.ColorCompare(VertDownLeftDownColor, mGiallo) && !mGameManager.ColorCompare(VertDownRightDownColor, mGiallo)){ //Quadrati intersecati sbagliati
					mAnimatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 });
					mGameManager.HoFattoPiuMosse (9);
				} else {
					mFase6Completata = true;
				}
			} else if (!mFase7Completata){																																			//FASE 7
				if (!Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					if (mGameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor)) {
						if (mGameManager.ColorCompare(VertFrontLeftDownColor, mRosso)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 });
							mGameManager.HoFattoPiuMosse (12);
						} else if(mGameManager.ColorCompare(VertFrontLeftDownColor, mVerde)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 });
							mGameManager.HoFattoPiuMosse (13);
						} else if(mGameManager.ColorCompare(VertFrontLeftDownColor, mArancione)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 });
							mGameManager.HoFattoPiuMosse (14);
						} else if(mGameManager.ColorCompare(VertFrontLeftDownColor, mBlu)) {
							mAnimatore.EseguiPiuMosse (new int[]{ 11, 1, 6, 1, 7, 7, 2, 5, 1, 7, 7, 1, 1 }, mVelocitaEsecuzione);
							mHelpMeTutor.AggiungiMosse (new int[]{ 11, 1, 6, 1, 7, 7, 2, 5, 1, 7, 7, 1, 1 });
							mGameManager.HoFattoPiuMosse (13);
						}
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
						mGameManager.HoFattoUnaMossa ();
					}
				} else if (Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					mAnimatore.EseguiPiuMosse (new int[]{ 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, mVelocitaEsecuzione);
					mHelpMeTutor.AggiungiMosse (new int[]{ 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 });
					mGameManager.HoFattoPiuMosse (12);
				} else {
					mFase7Completata = true;
				}
			} else if (!mFase8Completata){																																			//FASE 8
				if (!Fase8Completata ()) {
					if(Fase8NonCiSonoLineeComplete()){
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3});
						mGameManager.HoFattoPiuMosse (12);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mRosso) && mGameManager.ColorCompare(VertFrontLeftDownColor, mRosso) && mGameManager.ColorCompare(VertFrontRightDownColor, mRosso)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3});
						mGameManager.HoFattoPiuMosse (12);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mVerde) && mGameManager.ColorCompare(VertFrontLeftDownColor, mVerde) && mGameManager.ColorCompare(VertFrontRightDownColor, mVerde)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7}, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7});
						mGameManager.HoFattoPiuMosse (13);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mArancione) && mGameManager.ColorCompare(VertFrontLeftDownColor, mArancione) && mGameManager.ColorCompare(VertFrontRightDownColor, mArancione)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1}, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1});
						mGameManager.HoFattoPiuMosse (14);
					} else if (mGameManager.ColorCompare(SpigFrontDownColor, mBlu) && mGameManager.ColorCompare(VertFrontLeftDownColor, mBlu) && mGameManager.ColorCompare(VertFrontRightDownColor, mBlu)) {
						mAnimatore.EseguiPiuMosse (new int[]{ 11, 5, 5, 12, 4, 1, 5, 5, 3, 2, 12, 5, 5}, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11, 5, 5, 12, 4, 1, 5, 5, 3, 2, 12, 5, 5});
						mGameManager.HoFattoPiuMosse (13);
					} else {
						mAnimatore.EseguiPiuMosse (new int[]{ 11 }, mVelocitaEsecuzione);
						mHelpMeTutor.AggiungiMosse (new int[]{ 11 });
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

	public void HelpMeCalcola(){

		mHelpMeTutor.setCalcErrorVisibility (false);

		//CONTROLLO PRIMA DI INIZIARE

		List<Color> spigoli = new List<Color>();
		spigoli.Add(mStatoCubo.getSpigFrontUpColor());
		spigoli.Add(mStatoCubo.getSpigFrontLeftColor());
		spigoli.Add(mStatoCubo.getSpigFrontRightColor());
		spigoli.Add(mStatoCubo.getSpigFrontDownColor());
		spigoli.Add(mStatoCubo.getSpigBackUpColor());
		spigoli.Add(mStatoCubo.getSpigBackLeftColor());
		spigoli.Add(mStatoCubo.getSpigBackRightColor());
		spigoli.Add(mStatoCubo.getSpigBackDownColor());
		spigoli.Add(mStatoCubo.getSpigRightUpColor());
		spigoli.Add(mStatoCubo.getSpigRightLeftColor());
		spigoli.Add(mStatoCubo.getSpigRightRightColor());
		spigoli.Add(mStatoCubo.getSpigRightDownColor());
		spigoli.Add(mStatoCubo.getSpigLeftUpColor());
		spigoli.Add(mStatoCubo.getSpigLeftLeftColor());
		spigoli.Add(mStatoCubo.getSpigLeftRightColor());
		spigoli.Add(mStatoCubo.getSpigLeftDownColor());
		spigoli.Add(mStatoCubo.getSpigUpUpColor());
		spigoli.Add(mStatoCubo.getSpigUpLeftColor());
		spigoli.Add(mStatoCubo.getSpigUpRightColor());
		spigoli.Add(mStatoCubo.getSpigUpDownColor());
		spigoli.Add(mStatoCubo.getSpigDownUpColor());
		spigoli.Add(mStatoCubo.getSpigDownLeftColor());
		spigoli.Add(mStatoCubo.getSpigDownRightColor());
		spigoli.Add(mStatoCubo.getSpigDownDownColor());

		List<Color> vertici = new List<Color>();
		vertici.Add(mStatoCubo.getVertFrontRightUpColor());
		vertici.Add(mStatoCubo.getVertFrontRightDownColor());
		vertici.Add(mStatoCubo.getVertFrontLeftUpColor());
		vertici.Add(mStatoCubo.getVertFrontLeftDownColor());
		vertici.Add(mStatoCubo.getVertBackRightUpColor());
		vertici.Add(mStatoCubo.getVertBackRightDownColor());
		vertici.Add(mStatoCubo.getVertBackLeftUpColor());
		vertici.Add(mStatoCubo.getVertBackLeftDownColor());
		vertici.Add(mStatoCubo.getVertLeftRightUpColor());
		vertici.Add(mStatoCubo.getVertLeftRightDownColor());
		vertici.Add(mStatoCubo.getVertLeftLeftUpColor());
		vertici.Add(mStatoCubo.getVertLeftLeftDownColor());
		vertici.Add(mStatoCubo.getVertRightRightUpColor());
		vertici.Add(mStatoCubo.getVertRightRightDownColor());
		vertici.Add(mStatoCubo.getVertRightLeftUpColor());
		vertici.Add(mStatoCubo.getVertRightLeftDownColor());
		vertici.Add(mStatoCubo.getVertUpRightUpColor());
		vertici.Add(mStatoCubo.getVertUpRightDownColor());
		vertici.Add(mStatoCubo.getVertUpLeftUpColor());
		vertici.Add(mStatoCubo.getVertUpLeftDownColor());
		vertici.Add(mStatoCubo.getVertDownRightUpColor());
		vertici.Add(mStatoCubo.getVertDownRightDownColor());
		vertici.Add(mStatoCubo.getVertDownLeftUpColor());
		vertici.Add(mStatoCubo.getVertDownLeftDownColor());

		int contSpigRosso, contSpigArancione, contSpigVerde, contSpigBlu, contSpigBianco, contSpigGiallo;
		contSpigRosso=contSpigArancione=contSpigVerde=contSpigBlu=contSpigBianco=contSpigGiallo=0;

		int contVertRosso, contVertArancione, contVertVerde, contVertBlu, contVertBianco, contVertGiallo;
		contVertRosso=contVertArancione=contVertVerde=contVertBlu=contVertBianco=contVertGiallo=0;

		for(int i=0;i<spigoli.Count;i++){
			if (mGameManager.ColorCompare (spigoli [i], mStatoCubo.getCentFrontColor ())) {
				contSpigRosso++;
			} else if (mGameManager.ColorCompare (spigoli [i], mStatoCubo.getCentBackColor ())) {
				contSpigArancione++;
			} else if (mGameManager.ColorCompare (spigoli [i], mStatoCubo.getCentLeftColor ())) {
				contSpigVerde++;
			} else if (mGameManager.ColorCompare (spigoli [i], mStatoCubo.getCentRightColor ())) {
				contSpigBlu++;
			} else if (mGameManager.ColorCompare (spigoli [i], mStatoCubo.getCentUpColor ())) {
				contSpigBianco++;
			} else if (mGameManager.ColorCompare (spigoli [i], mStatoCubo.getCentDownColor ())) {
				contSpigGiallo++;
			}


			if (mGameManager.ColorCompare (vertici [i], mStatoCubo.getCentFrontColor ())) {
				contVertRosso++;
			} else if (mGameManager.ColorCompare (vertici [i], mStatoCubo.getCentBackColor ())) {
				contVertArancione++;
			} else if (mGameManager.ColorCompare (vertici [i], mStatoCubo.getCentLeftColor ())) {
				contVertVerde++;
			} else if (mGameManager.ColorCompare (vertici [i], mStatoCubo.getCentRightColor ())) {
				contVertBlu++;
			} else if (mGameManager.ColorCompare (vertici [i], mStatoCubo.getCentUpColor ())) {
				contVertBianco++;
			} else if (mGameManager.ColorCompare (vertici [i], mStatoCubo.getCentDownColor ())) {
				contVertGiallo++;
			}
		}

		if (!(contSpigRosso == 4 && contVertRosso == 4 &&
		   contSpigArancione == 4 && contVertArancione == 4 &&
		   contSpigVerde == 4 && contVertVerde == 4 &&
		   contSpigBlu == 4 && contVertBlu == 4 &&
		   contSpigBianco == 4 && contVertBianco == 4 &&
		   contSpigGiallo == 4 && contVertGiallo == 4)) {
			mHelpMeTutor.FineCalcolo (false);
			return;
		}

		//INIZIO RISOLUZIONE

		FileManager.setFilename ("HelpMeSaveFile");
		FileManager.salvaSuFile ();
		mRisolvi = true;
		mGameManager.ResetMosseEseguite ();
		mStatistiche.TimeReset ();
		mAnimatore.SetStatoStoRisolvendo (true);
	}
}
