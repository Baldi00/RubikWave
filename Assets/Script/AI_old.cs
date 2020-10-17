using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_old : MonoBehaviour {
	private StatoCubo m_StatoCubo;
	private GameManager m_GameManager;
	private StatisticheInGame m_Statistiche;
	private Animatore m_Animatore;
	
	private GameObject CentFront,CentBack,CentRight,CentLeft,CentUp,CentDown;

	private GameObject SpigFrontUp,SpigFrontLeft,SpigFrontRight,SpigFrontDown,SpigBackUp,SpigBackLeft,SpigBackRight,SpigBackDown,
	SpigRightUp,SpigRightLeft,SpigRightRight,SpigRightDown,SpigLeftUp,SpigLeftLeft,SpigLeftRight,SpigLeftDown,
	SpigUpUp,SpigUpLeft,SpigUpRight,SpigUpDown,SpigDownUp,SpigDownLeft,SpigDownRight,SpigDownDown;

	private GameObject VertFrontRightUp,VertFrontRightDown,VertFrontLeftUp,VertFrontLeftDown,VertBackRightUp,VertBackRightDown,VertBackLeftUp,VertBackLeftDown,
	VertLeftRightUp,VertLeftRightDown,VertLeftLeftUp,VertLeftLeftDown,VertRightRightUp,VertRightRightDown,VertRightLeftUp,VertRightLeftDown,
	VertUpRightUp,VertUpRightDown,VertUpLeftUp,VertUpLeftDown,VertDownRightUp,VertDownRightDown,VertDownLeftUp,VertDownLeftDown;

	private Color m_Bianco, m_Rosso, m_Blu, m_Verde, m_Giallo, m_Arancione;

	private bool m_Risolvi;

	private bool m_Fase1Completata, m_Fase2Completata, m_Fase3Completata, m_Fase4Completata, m_Fase5Completata, m_Fase6Completata, m_Fase7Completata, m_Fase8Completata;
	private bool m_Fase2RossoOK, m_Fase2VerdeOK, m_Fase2BluOK, m_Fase2ArancioneOK;

	[SerializeField]
	private int m_VelocitaEsecuzione = 10;

	// Use this for initialization
	void Start () {
		m_Risolvi = false;

		m_StatoCubo = GameObject.Find ("GameManager").GetComponent<StatoCubo> ();
		m_GameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		m_Statistiche = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame> ();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore> ();

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

		m_Bianco = CentUp.GetComponent<Renderer> ().material.color;
		m_Rosso = CentFront.GetComponent<Renderer> ().material.color;
		m_Blu = CentRight.GetComponent<Renderer> ().material.color;
		m_Verde = CentLeft.GetComponent<Renderer> ().material.color;
		m_Arancione = CentBack.GetComponent<Renderer> ().material.color;
		m_Giallo = CentDown.GetComponent<Renderer> ().material.color;

		m_Fase1Completata = false;
		m_Fase2Completata = false;
		m_Fase3Completata = false;
		m_Fase4Completata = false;
		m_Fase5Completata = false;
		m_Fase6Completata = false;
		m_Fase7Completata = false;
		m_Fase8Completata = false;

		m_Fase2RossoOK = false;
		m_Fase2BluOK = false;
		m_Fase2ArancioneOK = false;
		m_Fase2VerdeOK = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare () && Fase8Completata ()) {			//Controllo se il cubo è risolto
			m_GameManager.ControllaSeHoVinto ();
			Reset ();
		}

		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare ()) {
			if (!m_Fase1Completata) {																				//FASE 1
				if (SpigUpRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigUpUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigUpLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5, 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigUpDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1, 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigFrontLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigRightLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigBackLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigLeftLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigFrontRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 8 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigRightRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 4 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigBackRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 6 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigLeftRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 2 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigFrontUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || SpigRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigBackUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || SpigBackDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (SpigLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || SpigLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					if (!SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else {
					m_Fase1Completata = true;
				}
			} else if (!m_Fase2Completata) {																		//FASE 2
				if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && !m_Fase2RossoOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 1 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2RossoOK = true;
				} else if (!(SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) && !m_Fase2RossoOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else if (SpigRightDown.GetComponent<Renderer> ().material.color.Equals (m_Blu) && SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && !m_Fase2BluOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 7 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2BluOK = true;
				} else if (!(SpigRightDown.GetComponent<Renderer> ().material.color.Equals (m_Blu) && SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) && !m_Fase2BluOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else if (SpigBackDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && !m_Fase2ArancioneOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 3 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2ArancioneOK = true;
				} else if (!(SpigBackDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) && !m_Fase2ArancioneOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else if (SpigLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Verde) && SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && !m_Fase2VerdeOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 5 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2VerdeOK = true;
				} else if (!(SpigLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Verde) && SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) && !m_Fase2VerdeOK) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else {
					m_Fase2Completata = true;
				}
			} else if (!m_Fase3Completata) {																		//FASE 3
				if (!Fase3SuperioriOK ()) {																			//Parte 1 - Controllo superiori
					if (VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {			
						if (VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (8);
						} else if (VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (9);
						} else if (VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (10);
						} else if (VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (9);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3FrontaliOK ()) {																			//Parte 2 - Controllo frontali
					if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {		
						if (VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 2, 12, 1 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (3);
						}else if (VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Blu)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 8, 12, 7 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						}else if (VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Arancione)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 4, 12, 3 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (5);
						}else if (VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Verde)){
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 6, 12, 5 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3LateraliOK ()) {																				//Parte 3 - Controllo laterali
					if (VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
						if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (3);
						} else if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Blu)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 2 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						} else if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 8 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (5);
						} else if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Verde)){
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 4 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						}
					} else {
							m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoUnaMossa ();
					} 
				} else if (VertFrontLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || VertLeftRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {  //Parte 4 - Controllo se alcuni sono sotto
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (VertRightLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || VertFrontRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (VertBackLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || VertRightRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (VertLeftLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) || VertBackRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!VertFrontLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {  																				//Parte 5 - Controllo se posizioni sbagliate: bianco giusto, lati sbagliati
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!VertRightLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!VertBackLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!VertLeftLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else {
					if (Fase3PavimentoBiancoCompletato ()) {
						m_Fase3Completata = true;
					}
				}
			} else if(!m_Fase4Completata){																																			//FASE 4
				if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Verde) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (7);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Blu) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (9);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Blu) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (7);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Verde) && SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (9);

				} else if (!Fase4Completata () && Fase4PossoContinuareAGirareSuperiore ()) {
					
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();

				} else if(!Fase4Completata()){
					
					if (!SpigFrontRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigFrontRight.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && !SpigRightLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigRightLeft.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!SpigRightRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigRightRight.GetComponent<Renderer> ().material.color.Equals (m_Blu) && !SpigBackLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigBackLeft.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!SpigBackRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigBackRight.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && !SpigLeftLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigLeftLeft.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!SpigLeftRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigLeftRight.GetComponent<Renderer> ().material.color.Equals (m_Verde) && !SpigFrontLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigFrontLeft.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					}

				} else{
					m_Fase4Completata = true;
				}
			} else if(!m_Fase5Completata){																																			//FASE 5
				if (SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 3, 12, 4, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 5, 12, 6, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 1, 12, 2, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 7, 11, 8, 12, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 3, 11, 4, 12, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else {
					m_Fase5Completata = true;
				}
			} else if (!m_Fase6Completata){																																			//FASE 6
				if(Fase6UnoAcceso()){	//Croce + basso sinistra
					if (VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (8);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo)){ //Croce
					if (VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertLeftLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (8);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (Fase6TSpessa()){ //T spessa punta giu
					if (!VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
						if (VertBackLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertBackRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (8);
						} else {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (9);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)){ //Quadrati intersecati giusti
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)){ //Quadrati intersecati sbagliati
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (9);
				} else {
					m_Fase6Completata = true;
				}
			} else if (!m_Fase7Completata){																																			//FASE 7
				if (!Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (VertFrontRightDown.GetComponent<Renderer> ().material.color)) {
						if (VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (12);
						} else if(VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (13);
						} else if(VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (14);
						} else if(VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 6, 1, 7, 7, 2, 5, 1, 7, 7, 1, 1 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (13);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (12);
				} else {
					m_Fase7Completata = true;
				}
			} else if (!m_Fase8Completata){																																			//FASE 8
				if (!Fase8Completata ()) {
					if(Fase8NonCiSonoLineeComplete()){
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (12);
					} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso) && VertFrontRightDown.GetComponent<Renderer> ().material.color.Equals (m_Rosso)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (12);
					} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Verde) && VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Verde) && VertFrontRightDown.GetComponent<Renderer> ().material.color.Equals (m_Verde)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (13);
					} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione) && VertFrontRightDown.GetComponent<Renderer> ().material.color.Equals (m_Arancione)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (14);
					} else if (SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Blu) && VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Blu) && VertFrontRightDown.GetComponent<Renderer> ().material.color.Equals (m_Blu)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 11, 5, 5, 12, 4, 1, 5, 5, 3, 2, 12, 5, 5}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (13);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else {
					m_Fase8Completata = true;
				}
			} else {
				Reset ();
			}
		}
	}

	public bool Fase1QuattroBiachiConGialloInMezzo(){  	//Condizione fine fase 1
		return 	
			SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && 
			SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco);
	}

	public bool Fase2CroceBiancaCompletata(){			//Condizione fine fase 2
		return
			SpigUpUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigUpLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && 
			SpigUpDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigUpRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigFrontUp.GetComponent<Renderer> ().material.color.Equals (m_Rosso) &&
			SpigRightUp.GetComponent<Renderer> ().material.color.Equals (m_Blu) &&
			SpigBackUp.GetComponent<Renderer> ().material.color.Equals (m_Arancione) &&
			SpigLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Verde);
	}

	public bool Fase3PavimentoBiancoCompletato(){		//Condizione fine fase 3
		return 
			SpigUpUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigUpLeft.GetComponent<Renderer> ().material.color.Equals (m_Bianco) && 
			SpigUpDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			SpigUpRight.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			VertUpLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			VertUpLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			VertUpRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			VertUpRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco);
	}

	public bool Fase3FrontaliOK(){
		return
			!VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertLeftLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertBackLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertRightLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco);

	}

	public bool Fase3LateraliOK(){
		return
			!VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertFrontRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertRightRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertBackRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco);

	}

	public bool Fase3SuperioriOK(){
		return
			!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Bianco) &&
			!VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Bianco);

	}

	public bool Fase4Completata(){							//Condizione fine fase 4
		return
			SpigFrontLeft.GetComponent<Renderer> ().material.color.Equals (m_Rosso) &&
			SpigFrontRight.GetComponent<Renderer> ().material.color.Equals (m_Rosso) &&
			SpigLeftLeft.GetComponent<Renderer> ().material.color.Equals (m_Verde) &&
			SpigLeftRight.GetComponent<Renderer> ().material.color.Equals (m_Verde) &&
			SpigRightLeft.GetComponent<Renderer> ().material.color.Equals (m_Blu) &&
			SpigRightRight.GetComponent<Renderer> ().material.color.Equals (m_Blu) &&
			SpigBackLeft.GetComponent<Renderer> ().material.color.Equals (m_Arancione) &&
			SpigBackRight.GetComponent<Renderer> ().material.color.Equals (m_Arancione);
	}

	public bool Fase4PossoContinuareAGirareSuperiore(){
		return
			(!SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!SpigRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!SpigBackDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!SpigLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo));
	}

	public bool Fase5Completata(){							//Condizione fine fase 5
		return
			SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo);
	}

	public bool Fase6UnoAcceso(){
		return
			(VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo));
	}

	public bool Fase6TSpessa(){
		return
			(VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(!VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo)) ||
			(VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) && !VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo));
	}

	public bool Fase6Completata(){							//Condizione fine fase 6
		return
			SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			SpigDownUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			SpigDownRight.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			SpigDownDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (m_Giallo) &&
			VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (m_Giallo);
	}

	public bool Fase7TuttiDiversi(){
		return
			!VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (VertFrontRightDown.GetComponent<Renderer> ().material.color) &&
			!VertLeftLeftDown.GetComponent<Renderer> ().material.color.Equals (VertLeftRightDown.GetComponent<Renderer> ().material.color) &&
			!VertBackLeftDown.GetComponent<Renderer> ().material.color.Equals (VertBackRightDown.GetComponent<Renderer> ().material.color) &&
			!VertRightLeftDown.GetComponent<Renderer> ().material.color.Equals (VertRightRightDown.GetComponent<Renderer> ().material.color);
	}

	public bool Fase7TuttiUguali(){							//Condizione fine fase 7
		return
			VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (VertFrontRightDown.GetComponent<Renderer> ().material.color) &&
			VertLeftLeftDown.GetComponent<Renderer> ().material.color.Equals (VertLeftRightDown.GetComponent<Renderer> ().material.color) &&
			VertBackLeftDown.GetComponent<Renderer> ().material.color.Equals (VertBackRightDown.GetComponent<Renderer> ().material.color) &&
			VertRightLeftDown.GetComponent<Renderer> ().material.color.Equals (VertRightRightDown.GetComponent<Renderer> ().material.color);
	}

	public bool Fase8NonCiSonoLineeComplete(){
		return
			!VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (SpigFrontDown.GetComponent<Renderer> ().material.color) &&
			!VertRightLeftDown.GetComponent<Renderer> ().material.color.Equals (SpigRightDown.GetComponent<Renderer> ().material.color) &&
			!VertBackLeftDown.GetComponent<Renderer> ().material.color.Equals (SpigBackDown.GetComponent<Renderer> ().material.color) &&
			!VertLeftLeftDown.GetComponent<Renderer> ().material.color.Equals (SpigLeftDown.GetComponent<Renderer> ().material.color);
	}

	public bool Fase8Completata(){							//Condizione fine fase 7
		return m_StatoCubo.IsStatoIniziale();
	}



	public void Risolvi(){
		m_Risolvi = true;
		m_GameManager.ResetMosseEseguite ();
		m_Statistiche.TimeReset ();
		m_Animatore.SetStatoStoRisolvendo (true);
	}

	public void Reset(){
		m_Fase1Completata = false;
		m_Fase2Completata = false;
		m_Fase3Completata = false;
		m_Fase4Completata = false;
		m_Fase5Completata = false;
		m_Fase6Completata = false;
		m_Fase7Completata = false;
		m_Fase8Completata = false;

		m_Fase2RossoOK = false;
		m_Fase2BluOK = false;
		m_Fase2ArancioneOK = false;
		m_Fase2VerdeOK = false;

		m_Risolvi = false;
		m_Animatore.SetStatoStoRisolvendo (false);
	}
}
