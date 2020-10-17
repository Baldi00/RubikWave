using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {
	protected StatoCubo m_StatoCubo;
	protected GameManager m_GameManager;
	protected StatisticheInGame m_Statistiche;
	protected Animatore m_Animatore;
	
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

	protected Color m_Bianco, m_Rosso, m_Blu, m_Verde, m_Giallo, m_Arancione;

	protected bool m_Risolvi;

	protected bool m_Fase1Completata, m_Fase2Completata, m_Fase3Completata, m_Fase4Completata, m_Fase5Completata, m_Fase6Completata, m_Fase7Completata, m_Fase8Completata;
	protected bool m_Fase2RossoOK, m_Fase2VerdeOK, m_Fase2BluOK, m_Fase2ArancioneOK;

	[SerializeField]
	protected int m_VelocitaEsecuzione = 10;

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

		AggiornaColori ();

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

	protected void AggiornaColori () {
		m_Bianco = CentUp.GetComponent<Renderer> ().material.color;
		m_Rosso = CentFront.GetComponent<Renderer> ().material.color;
		m_Blu = CentRight.GetComponent<Renderer> ().material.color;
		m_Verde = CentLeft.GetComponent<Renderer> ().material.color;
		m_Arancione = CentBack.GetComponent<Renderer> ().material.color;
		m_Giallo = CentDown.GetComponent<Renderer> ().material.color;

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
		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare () && Fase8Completata ()) {			//Controllo se il cubo è risolto
			AggiornaColori();
			m_GameManager.ControllaSeHoVinto ();
			Reset ();
		}

		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare ()) {
			AggiornaColori ();
			if (!m_Fase1Completata) {																				//FASE 1
				if (m_GameManager.ColorCompare(SpigUpRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigUpUpColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigUpLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5, 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigUpDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1, 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigFrontLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigRightLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigBackLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigLeftLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigFrontRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 8 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigRightRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 4 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigBackRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 6 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigLeftRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 2 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigFrontUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigFrontDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigRightUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigRightDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigBackUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigBackDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigLeftDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
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
				int TEMP = 1;
				if (!m_Fase2RossoOK && m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 1 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2RossoOK = true;
				} else if (!m_Fase2RossoOK && !(m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else if (!m_Fase2BluOK && m_GameManager.ColorCompare(SpigRightDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 7 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2BluOK = true;
				} else if (!m_Fase2BluOK && !(m_GameManager.ColorCompare(SpigRightDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else if (!m_Fase2ArancioneOK && m_GameManager.ColorCompare(SpigBackDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 3 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2ArancioneOK = true;
				} else if (!m_Fase2ArancioneOK && !(m_GameManager.ColorCompare(SpigBackDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else if (!m_Fase2VerdeOK && m_GameManager.ColorCompare(SpigLeftDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 5 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2VerdeOK = true;
				} else if (!m_Fase2VerdeOK && !(m_GameManager.ColorCompare(SpigLeftDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();
				} else {
					m_Fase2Completata = true;
				}
			} else if (!m_Fase3Completata) {																		//FASE 3
				if (!Fase3SuperioriOK ()) {																			//Parte 1 - Controllo superiori
					if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Bianco)) {			
						if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (8);
						} else if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Blu)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (9);
						} else if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Arancione)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (10);
						} else if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Verde)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (9);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3FrontaliOK ()) {																			//Parte 2 - Controllo frontali
					if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Bianco)) {		
						if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 2, 12, 1 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (3);
						}else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Blu)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 8, 12, 7 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						}else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Arancione)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 4, 12, 3 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (5);
						}else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Verde)){
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 6, 12, 5 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3LateraliOK ()) {																				//Parte 3 - Controllo laterali
					if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Bianco)) {
						if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (3);
						} else if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Blu)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 2 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						} else if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Arancione)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 8 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (5);
						} else if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Verde)){
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 4 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (4);
						}
					} else {
							m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoUnaMossa ();
					} 
				} else if (m_GameManager.ColorCompare(VertFrontLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertLeftRightUpColor, m_Bianco)) {  //Parte 4 - Controllo se alcuni sono sotto
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (m_GameManager.ColorCompare(VertRightLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertFrontRightUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (m_GameManager.ColorCompare(VertBackLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertRightRightUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (m_GameManager.ColorCompare(VertLeftLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertBackRightUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertFrontLeftUpColor, m_Rosso)) {  																				//Parte 5 - Controllo se posizioni sbagliate: bianco giusto, lati sbagliati
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertRightLeftUpColor, m_Blu)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertBackLeftUpColor, m_Arancione)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertLeftLeftUpColor, m_Verde)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (3);
				} else {
					if (Fase3PavimentoBiancoCompletato ()) {
						m_Fase3Completata = true;
					}
				}
			} else if(!m_Fase4Completata){																																			//FASE 4
				if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Verde)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownUpColor, m_Arancione)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (7);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownUpColor, m_Blu)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownUpColor, m_Rosso)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (9);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Blu)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownUpColor, m_Arancione)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (7);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownUpColor, m_Verde)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownUpColor, m_Rosso)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (9);

				} else if (!Fase4Completata () && Fase4PossoContinuareAGirareSuperiore ()) {
					
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoUnaMossa ();

				} else if(!Fase4Completata()){
					
					if (!m_GameManager.ColorCompare(SpigFrontRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigFrontRightColor, m_Rosso) && !m_GameManager.ColorCompare(SpigRightLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigRightLeftColor, m_Blu)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!m_GameManager.ColorCompare(SpigRightRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigRightRightColor, m_Blu) && !m_GameManager.ColorCompare(SpigBackLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigBackLeftColor, m_Arancione)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!m_GameManager.ColorCompare(SpigBackRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigBackRightColor, m_Arancione) && !m_GameManager.ColorCompare(SpigLeftLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigLeftLeftColor, m_Verde)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!m_GameManager.ColorCompare(SpigLeftRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigLeftRightColor, m_Verde) && !m_GameManager.ColorCompare(SpigFrontLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigFrontLeftColor, m_Rosso)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (7);
					}

				} else{
					m_Fase4Completata = true;
				}
			} else if(!m_Fase5Completata){																																			//FASE 5
				if (m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 3, 12, 4, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 5, 12, 6, 2 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 1, 12, 2, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 7, 11, 8, 12, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 3, 11, 4, 12, 6 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (6);
				} else {
					m_Fase5Completata = true;
				}
			} else if (!m_Fase6Completata){																																			//FASE 6
				if(Fase6UnoAcceso()){	//Croce + basso sinistra
					if (m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (8);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo)){ //Croce
					if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Giallo) && m_GameManager.ColorCompare(VertLeftLeftDownColor, m_Giallo)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (8);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (Fase6TSpessa()){ //T spessa punta giu
					if (!m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) {
						if (m_GameManager.ColorCompare(VertBackLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertBackRightDownColor, m_Giallo)) {
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
				} else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)){ //Quadrati intersecati giusti
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (8);
				} else if (!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)){ //Quadrati intersecati sbagliati
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
					m_GameManager.HoFattoPiuMosse (9);
				} else {
					m_Fase6Completata = true;
				}
			} else if (!m_Fase7Completata){																																			//FASE 7
				if (!Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					if (m_GameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor)) {
						if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (12);
						} else if(m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Verde)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (13);
						} else if(m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Arancione)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, m_VelocitaEsecuzione);
							m_GameManager.HoFattoPiuMosse (14);
						} else if(m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Blu)) {
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
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Rosso) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Rosso)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (12);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Verde) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Verde) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Verde)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (13);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Arancione) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Arancione) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Arancione)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1}, m_VelocitaEsecuzione);
						m_GameManager.HoFattoPiuMosse (14);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Blu) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Blu) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Blu)) {
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
			m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco) && 
			m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco);
	}

	public bool Fase2CroceBiancaCompletata(){			//Condizione fine fase 2
		return
			m_GameManager.ColorCompare(SpigUpUpColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigUpLeftColor, m_Bianco) && 
			m_GameManager.ColorCompare(SpigUpDownColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigUpRightColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigFrontUpColor, m_Rosso) &&
			m_GameManager.ColorCompare(SpigRightUpColor, m_Blu) &&
			m_GameManager.ColorCompare(SpigBackUpColor, m_Arancione) &&
			m_GameManager.ColorCompare(SpigLeftUpColor, m_Verde);
	}

	public bool Fase3PavimentoBiancoCompletato(){		//Condizione fine fase 3
		return 
			m_GameManager.ColorCompare(SpigUpUpColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigUpLeftColor, m_Bianco) && 
			m_GameManager.ColorCompare(SpigUpDownColor, m_Bianco) &&
			m_GameManager.ColorCompare(SpigUpRightColor, m_Bianco) &&
			m_GameManager.ColorCompare(VertUpLeftUpColor, m_Bianco) &&
			m_GameManager.ColorCompare(VertUpLeftDownColor, m_Bianco) &&
			m_GameManager.ColorCompare(VertUpRightUpColor, m_Bianco) &&
			m_GameManager.ColorCompare(VertUpRightDownColor, m_Bianco);
	}

	public bool Fase3FrontaliOK(){
		return
			!m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertLeftLeftDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertBackLeftDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertRightLeftDownColor, m_Bianco);

	}

	public bool Fase3LateraliOK(){
		return
			!m_GameManager.ColorCompare(VertLeftRightDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertFrontRightDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertRightRightDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertBackRightDownColor, m_Bianco);

	}

	public bool Fase3SuperioriOK(){
		return
			!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertDownLeftDownColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertDownRightUpColor, m_Bianco) &&
			!m_GameManager.ColorCompare(VertDownRightDownColor, m_Bianco);

	}

	public bool Fase4Completata(){							//Condizione fine fase 4
		return
			m_GameManager.ColorCompare(SpigFrontLeftColor, m_Rosso) &&
			m_GameManager.ColorCompare(SpigFrontRightColor, m_Rosso) &&
			m_GameManager.ColorCompare(SpigLeftLeftColor, m_Verde) &&
			m_GameManager.ColorCompare(SpigLeftRightColor, m_Verde) &&
			m_GameManager.ColorCompare(SpigRightLeftColor, m_Blu) &&
			m_GameManager.ColorCompare(SpigRightRightColor, m_Blu) &&
			m_GameManager.ColorCompare(SpigBackLeftColor, m_Arancione) &&
			m_GameManager.ColorCompare(SpigBackRightColor, m_Arancione);
	}

	public bool Fase4PossoContinuareAGirareSuperiore(){
		return
			(!m_GameManager.ColorCompare(SpigFrontDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(SpigRightDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(SpigBackDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(SpigLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo));
	}

	public bool Fase5Completata(){							//Condizione fine fase 5
		return
			m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo) &&
			m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) &&
			m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) &&
			m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo);
	}

	public bool Fase6UnoAcceso(){
		return
			(m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo));
	}

	public bool Fase6TSpessa(){
		return
			(m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) ||
			(!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) ||
			(m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo));
	}

	public bool Fase6Completata(){							//Condizione fine fase 6
		return
			m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo) &&
			m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) &&
			m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) &&
			m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) &&
			m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) &&
			m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) &&
			m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) &&
			m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo);
	}

	public bool Fase7TuttiDiversi(){
		return
			!m_GameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor) &&
			!m_GameManager.ColorCompare(VertLeftLeftDownColor, VertLeftRightDownColor) &&
			!m_GameManager.ColorCompare(VertBackLeftDownColor, VertBackRightDownColor) &&
			!m_GameManager.ColorCompare(VertRightLeftDownColor, VertRightRightDownColor);
	}

	public bool Fase7TuttiUguali(){							//Condizione fine fase 7
		return
			m_GameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor) &&
			m_GameManager.ColorCompare(VertLeftLeftDownColor, VertLeftRightDownColor) &&
			m_GameManager.ColorCompare(VertBackLeftDownColor, VertBackRightDownColor) &&
			m_GameManager.ColorCompare(VertRightLeftDownColor, VertRightRightDownColor);
	}

	public bool Fase8NonCiSonoLineeComplete(){
		return
			!m_GameManager.ColorCompare(VertFrontLeftDownColor, SpigFrontDownColor) &&
			!m_GameManager.ColorCompare(VertRightLeftDownColor, SpigRightDownColor) &&
			!m_GameManager.ColorCompare(VertBackLeftDownColor, SpigBackDownColor) &&
			!m_GameManager.ColorCompare(VertLeftLeftDownColor, SpigLeftDownColor);
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
