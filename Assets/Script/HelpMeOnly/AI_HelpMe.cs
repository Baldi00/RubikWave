using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_HelpMe : AI {

	[SerializeField]
	private HelpMeTutor m_HelpMeTutor;

	void Update () {

		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare () && m_GameManager.GetNumMosseEseguite () >= 300) {
			Reset ();
			FileManager.caricaDaFile ();
			FileManager.setFilename ("saveFile");
			m_HelpMeTutor.FineCalcolo (false);
		}

		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare () && Fase8Completata ()) {			//Controllo se il cubo è risolto
			AggiornaColori();
			m_GameManager.ControllaSeHoVinto ();
			Reset ();
			int mosseEseguiteTemp = m_GameManager.GetNumMosseEseguite ();
			FileManager.caricaDaFile ();
			FileManager.setFilename ("saveFile");
			m_GameManager.HoFattoPiuMosse (mosseEseguiteTemp);
			m_HelpMeTutor.FineCalcolo (true);
		}

		if (m_Risolvi && m_GameManager.IsGameRunning () && m_Animatore.isFermoAnimatorePuoAndare ()) {
			AggiornaColori ();
			if (!m_Fase1Completata) {																				//FASE 1
				if (m_GameManager.ColorCompare(SpigUpRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 7 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 7 });
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigUpUpColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 3 });
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigUpLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5, 5 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 5 });
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigUpDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1, 1 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 1, 1 });
						m_GameManager.HoFattoPiuMosse (2);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigFrontLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 5 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigRightLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 1 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigBackLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 7 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigLeftLeftColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 3 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigFrontRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 8 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 8 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigRightRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 4 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 4 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigBackRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 6 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 6 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigLeftRightColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 2 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 2 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigFrontUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigFrontDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 1 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigRightUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigRightDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 7 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigBackUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigBackDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 3 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(SpigLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(SpigLeftDownColor, m_Bianco)) {
					if (!m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 5 });
						m_GameManager.HoFattoUnaMossa ();
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else {
					m_Fase1Completata = true;
				}
			} else if (!m_Fase2Completata) {																		//FASE 2
				int TEMP = 1;
				if (!m_Fase2RossoOK && m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 1 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 1, 1 });
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2RossoOK = true;
				} else if (!m_Fase2RossoOK && !(m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
					m_GameManager.HoFattoUnaMossa ();
				} else if (!m_Fase2BluOK && m_GameManager.ColorCompare(SpigRightDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 7 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 7 });
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2BluOK = true;
				} else if (!m_Fase2BluOK && !(m_GameManager.ColorCompare(SpigRightDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownRightColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
					m_GameManager.HoFattoUnaMossa ();
				} else if (!m_Fase2ArancioneOK && m_GameManager.ColorCompare(SpigBackDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 3 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 3 });
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2ArancioneOK = true;
				} else if (!m_Fase2ArancioneOK && !(m_GameManager.ColorCompare(SpigBackDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownDownColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
					m_GameManager.HoFattoUnaMossa ();
				} else if (!m_Fase2VerdeOK && m_GameManager.ColorCompare(SpigLeftDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 5 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 5 });
					m_GameManager.HoFattoPiuMosse (2);
					m_Fase2VerdeOK = true;
				} else if (!m_Fase2VerdeOK && !(m_GameManager.ColorCompare(SpigLeftDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Bianco))) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
					m_GameManager.HoFattoUnaMossa ();
				} else {
					m_Fase2Completata = true;
				}
			} else if (!m_Fase3Completata) {																		//FASE 3
				if (!Fase3SuperioriOK ()) {																			//Parte 1 - Controllo superiori
					if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Bianco)) {			
						if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 11, 6, 12, 5, 11, 6 });
							m_GameManager.HoFattoPiuMosse (8);
						} else if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Blu)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 1, 11, 11, 2, 12, 1, 11, 2 });
							m_GameManager.HoFattoPiuMosse (9);
						} else if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Arancione)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 7, 11, 11, 8, 12, 7, 11, 8 });
							m_GameManager.HoFattoPiuMosse (10);
						} else if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Verde)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 3, 11, 11, 4, 12, 3, 11, 4 });
							m_GameManager.HoFattoPiuMosse (9);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3FrontaliOK ()) {																			//Parte 2 - Controllo frontali
					if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Bianco)) {		
						if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 2, 12, 1 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 2, 12, 1 });
							m_GameManager.HoFattoPiuMosse (3);
						}else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Blu)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 8, 12, 7 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 8, 12, 7 });
							m_GameManager.HoFattoPiuMosse (4);
						}else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Arancione)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 4, 12, 3 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 4, 12, 3 });
							m_GameManager.HoFattoPiuMosse (5);
						}else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Verde)){
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 6, 12, 5 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 6, 12, 5 });
							m_GameManager.HoFattoPiuMosse (4);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!Fase3LateraliOK ()) {																				//Parte 3 - Controllo laterali
					if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Bianco)) {
						if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 6 });
							m_GameManager.HoFattoPiuMosse (3);
						} else if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Blu)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 11, 2 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 1, 11, 2 });
							m_GameManager.HoFattoPiuMosse (4);
						} else if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Arancione)){
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 11, 8 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 7, 11, 8 });
							m_GameManager.HoFattoPiuMosse (5);
						} else if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Verde)){
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 11, 4 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 3, 11, 4 });
							m_GameManager.HoFattoPiuMosse (4);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					} 
				} else if (m_GameManager.ColorCompare(VertFrontLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertLeftRightUpColor, m_Bianco)) {  //Parte 4 - Controllo se alcuni sono sotto
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 6 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (m_GameManager.ColorCompare(VertRightLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertFrontRightUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 1, 11, 2 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (m_GameManager.ColorCompare(VertBackLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertRightRightUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (m_GameManager.ColorCompare(VertLeftLeftUpColor, m_Bianco) || m_GameManager.ColorCompare(VertBackRightUpColor, m_Bianco)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 4 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertFrontLeftUpColor, m_Rosso)) {  																				//Parte 5 - Controllo se posizioni sbagliate: bianco giusto, lati sbagliati
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 6 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 6 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertRightLeftUpColor, m_Blu)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 2 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 1, 11, 2 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertBackLeftUpColor, m_Arancione)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8 });
					m_GameManager.HoFattoPiuMosse (3);
				} else if (!m_GameManager.ColorCompare(VertLeftLeftUpColor, m_Verde)) {  
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 4 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 4 });
					m_GameManager.HoFattoPiuMosse (3);
				} else {
					if (Fase3PavimentoBiancoCompletato ()) {
						m_Fase3Completata = true;
					}
				}
			} else if(!m_Fase4Completata){																																			//FASE 4
				if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Verde)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 5, 12, 6, 12, 2, 11, 1 });
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownUpColor, m_Arancione)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 });
					m_GameManager.HoFattoPiuMosse (7);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownUpColor, m_Blu)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 7, 12, 8, 12, 4, 11, 3 });
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownUpColor, m_Rosso)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 1, 12, 2, 12, 8, 11, 7 });
					m_GameManager.HoFattoPiuMosse (9);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(SpigDownUpColor, m_Blu)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 8, 11, 7, 11, 1, 12, 2 });
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Blu) && m_GameManager.ColorCompare(SpigDownUpColor, m_Arancione)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 4, 11, 3, 11, 7, 12, 8 });
					m_GameManager.HoFattoPiuMosse (7);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Arancione) && m_GameManager.ColorCompare(SpigDownUpColor, m_Verde)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 6, 11, 5, 11, 3, 12, 4 });
					m_GameManager.HoFattoPiuMosse (8);
				} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Verde) && m_GameManager.ColorCompare(SpigDownUpColor, m_Rosso)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 2, 11, 1, 11, 5, 12, 6 });
					m_GameManager.HoFattoPiuMosse (9);

				} else if (!Fase4Completata () && Fase4PossoContinuareAGirareSuperiore ()) {

					m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
					m_GameManager.HoFattoUnaMossa ();

				} else if(!Fase4Completata()){

					if (!m_GameManager.ColorCompare(SpigFrontRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigFrontRightColor, m_Rosso) && !m_GameManager.ColorCompare(SpigRightLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigRightLeftColor, m_Blu)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 1, 12, 2, 12, 8, 11, 7 });
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!m_GameManager.ColorCompare(SpigRightRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigRightRightColor, m_Blu) && !m_GameManager.ColorCompare(SpigBackLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigBackLeftColor, m_Arancione)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 12, 8, 12, 4, 11, 3 });
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!m_GameManager.ColorCompare(SpigBackRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigBackRightColor, m_Arancione) && !m_GameManager.ColorCompare(SpigLeftLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigLeftLeftColor, m_Verde)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 12, 4, 12, 6, 11, 5 });
						m_GameManager.HoFattoPiuMosse (7);
					} else if (!m_GameManager.ColorCompare(SpigLeftRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigLeftRightColor, m_Verde) && !m_GameManager.ColorCompare(SpigFrontLeftColor, m_Giallo) && !m_GameManager.ColorCompare(SpigFrontLeftColor, m_Rosso)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 12, 6, 12, 2, 11, 1 });
						m_GameManager.HoFattoPiuMosse (7);
					}

				} else{
					m_Fase4Completata = true;
				}
			} else if(!m_Fase5Completata){																																			//FASE 5
				if (m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 7, 12, 8, 4 });
					m_GameManager.HoFattoPiuMosse (6);
				} else if (m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 11, 3, 12, 4, 6 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 11, 3, 12, 4, 6 });
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 1, 11, 5, 12, 6, 2 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 1, 11, 5, 12, 6, 2 });
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 1, 12, 2, 8 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 1, 12, 2, 8 });
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 7, 11, 8, 12, 4 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 7, 11, 8, 12, 4 });
					m_GameManager.HoFattoPiuMosse (6);
				} else if (m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 5, 3, 11, 4, 12, 6 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 3, 11, 4, 12, 6 });
					m_GameManager.HoFattoPiuMosse (6);
				} else if (!m_GameManager.ColorCompare(SpigDownUpColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownRightColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownDownColor, m_Giallo) && !m_GameManager.ColorCompare(SpigDownLeftColor, m_Giallo)) {
					m_Animatore.EseguiPiuMosse (new int[]{ 3, 11, 7, 12, 8, 4 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 11, 7, 12, 8, 4 });
					m_GameManager.HoFattoPiuMosse (6);
				} else {
					m_Fase5Completata = true;
				}
			} else if (!m_Fase6Completata){																																			//FASE 6
				if(Fase6UnoAcceso()){	//Croce + basso sinistra
					if (m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
						m_GameManager.HoFattoPiuMosse (8);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (!m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo)){ //Croce
					if (m_GameManager.ColorCompare(VertLeftRightDownColor, m_Giallo) && m_GameManager.ColorCompare(VertLeftLeftDownColor, m_Giallo)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
						m_GameManager.HoFattoPiuMosse (8);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (Fase6TSpessa()){ //T spessa punta giu
					if (!m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)) {
						if (m_GameManager.ColorCompare(VertBackLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertBackRightDownColor, m_Giallo)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
							m_GameManager.HoFattoPiuMosse (8);
						} else {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 });
							m_GameManager.HoFattoPiuMosse (9);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)){ //Quadrati intersecati giusti
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 11, 8, 11, 7, 11, 11, 8 });
					m_GameManager.HoFattoPiuMosse (8);
				} else if (!m_GameManager.ColorCompare(VertDownLeftUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownRightUpColor, m_Giallo) && m_GameManager.ColorCompare(VertDownLeftDownColor, m_Giallo) && !m_GameManager.ColorCompare(VertDownRightDownColor, m_Giallo)){ //Quadrati intersecati sbagliati
					m_Animatore.EseguiPiuMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 7, 11, 8, 11, 7, 11, 11, 8 });
					m_GameManager.HoFattoPiuMosse (9);
				} else {
					m_Fase6Completata = true;
				}
			} else if (!m_Fase7Completata){																																			//FASE 7
				if (!Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					if (m_GameManager.ColorCompare(VertFrontLeftDownColor, VertFrontRightDownColor)) {
						if (m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Rosso)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 5, 4, 5, 1, 1, 6, 3, 5, 1, 1, 5, 5 });
							m_GameManager.HoFattoPiuMosse (12);
						} else if(m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Verde)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 3, 8, 3, 5, 5, 4, 7, 3, 5, 5, 3, 3 });
							m_GameManager.HoFattoPiuMosse (13);
						} else if(m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Arancione)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 });
							m_GameManager.HoFattoPiuMosse (14);
						} else if(m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Blu)) {
							m_Animatore.EseguiPiuMosse (new int[]{ 11, 1, 6, 1, 7, 7, 2, 5, 1, 7, 7, 1, 1 }, m_VelocitaEsecuzione);
							m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 1, 6, 1, 7, 7, 2, 5, 1, 7, 7, 1, 1 });
							m_GameManager.HoFattoPiuMosse (13);
						}
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
						m_GameManager.HoFattoUnaMossa ();
					}
				} else if (Fase7TuttiDiversi() && !Fase7TuttiUguali()) {
					m_Animatore.EseguiPiuMosse (new int[]{ 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 }, m_VelocitaEsecuzione);
					m_HelpMeTutor.AggiungiMosse (new int[]{ 7, 2, 7, 3, 3, 8, 1, 7, 3, 3, 7, 7 });
					m_GameManager.HoFattoPiuMosse (12);
				} else {
					m_Fase7Completata = true;
				}
			} else if (!m_Fase8Completata){																																			//FASE 8
				if (!Fase8Completata ()) {
					if(Fase8NonCiSonoLineeComplete()){
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3});
						m_GameManager.HoFattoPiuMosse (12);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Rosso) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Rosso) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Rosso)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3}, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 3, 3, 12, 8, 5, 3, 3, 7, 6, 12, 3, 3});
						m_GameManager.HoFattoPiuMosse (12);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Verde) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Verde) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Verde)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7}, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 12, 7, 7, 12, 2, 3, 7, 7, 1, 4, 12, 7, 7});
						m_GameManager.HoFattoPiuMosse (13);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Arancione) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Arancione) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Arancione)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1}, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 11, 1, 1, 12, 6, 7, 1, 1, 5, 8, 12, 1, 1});
						m_GameManager.HoFattoPiuMosse (14);
					} else if (m_GameManager.ColorCompare(SpigFrontDownColor, m_Blu) && m_GameManager.ColorCompare(VertFrontLeftDownColor, m_Blu) && m_GameManager.ColorCompare(VertFrontRightDownColor, m_Blu)) {
						m_Animatore.EseguiPiuMosse (new int[]{ 11, 5, 5, 12, 4, 1, 5, 5, 3, 2, 12, 5, 5}, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11, 5, 5, 12, 4, 1, 5, 5, 3, 2, 12, 5, 5});
						m_GameManager.HoFattoPiuMosse (13);
					} else {
						m_Animatore.EseguiPiuMosse (new int[]{ 11 }, m_VelocitaEsecuzione);
						m_HelpMeTutor.AggiungiMosse (new int[]{ 11 });
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

	public void HelpMeCalcola(){

		m_HelpMeTutor.setCalcErrorVisibility (false);

		//CONTROLLO PRIMA DI INIZIARE

		List<Color> spigoli = new List<Color>();
		spigoli.Add(m_StatoCubo.getSpigFrontUpColor());
		spigoli.Add(m_StatoCubo.getSpigFrontLeftColor());
		spigoli.Add(m_StatoCubo.getSpigFrontRightColor());
		spigoli.Add(m_StatoCubo.getSpigFrontDownColor());
		spigoli.Add(m_StatoCubo.getSpigBackUpColor());
		spigoli.Add(m_StatoCubo.getSpigBackLeftColor());
		spigoli.Add(m_StatoCubo.getSpigBackRightColor());
		spigoli.Add(m_StatoCubo.getSpigBackDownColor());
		spigoli.Add(m_StatoCubo.getSpigRightUpColor());
		spigoli.Add(m_StatoCubo.getSpigRightLeftColor());
		spigoli.Add(m_StatoCubo.getSpigRightRightColor());
		spigoli.Add(m_StatoCubo.getSpigRightDownColor());
		spigoli.Add(m_StatoCubo.getSpigLeftUpColor());
		spigoli.Add(m_StatoCubo.getSpigLeftLeftColor());
		spigoli.Add(m_StatoCubo.getSpigLeftRightColor());
		spigoli.Add(m_StatoCubo.getSpigLeftDownColor());
		spigoli.Add(m_StatoCubo.getSpigUpUpColor());
		spigoli.Add(m_StatoCubo.getSpigUpLeftColor());
		spigoli.Add(m_StatoCubo.getSpigUpRightColor());
		spigoli.Add(m_StatoCubo.getSpigUpDownColor());
		spigoli.Add(m_StatoCubo.getSpigDownUpColor());
		spigoli.Add(m_StatoCubo.getSpigDownLeftColor());
		spigoli.Add(m_StatoCubo.getSpigDownRightColor());
		spigoli.Add(m_StatoCubo.getSpigDownDownColor());

		List<Color> vertici = new List<Color>();
		vertici.Add(m_StatoCubo.getVertFrontRightUpColor());
		vertici.Add(m_StatoCubo.getVertFrontRightDownColor());
		vertici.Add(m_StatoCubo.getVertFrontLeftUpColor());
		vertici.Add(m_StatoCubo.getVertFrontLeftDownColor());
		vertici.Add(m_StatoCubo.getVertBackRightUpColor());
		vertici.Add(m_StatoCubo.getVertBackRightDownColor());
		vertici.Add(m_StatoCubo.getVertBackLeftUpColor());
		vertici.Add(m_StatoCubo.getVertBackLeftDownColor());
		vertici.Add(m_StatoCubo.getVertLeftRightUpColor());
		vertici.Add(m_StatoCubo.getVertLeftRightDownColor());
		vertici.Add(m_StatoCubo.getVertLeftLeftUpColor());
		vertici.Add(m_StatoCubo.getVertLeftLeftDownColor());
		vertici.Add(m_StatoCubo.getVertRightRightUpColor());
		vertici.Add(m_StatoCubo.getVertRightRightDownColor());
		vertici.Add(m_StatoCubo.getVertRightLeftUpColor());
		vertici.Add(m_StatoCubo.getVertRightLeftDownColor());
		vertici.Add(m_StatoCubo.getVertUpRightUpColor());
		vertici.Add(m_StatoCubo.getVertUpRightDownColor());
		vertici.Add(m_StatoCubo.getVertUpLeftUpColor());
		vertici.Add(m_StatoCubo.getVertUpLeftDownColor());
		vertici.Add(m_StatoCubo.getVertDownRightUpColor());
		vertici.Add(m_StatoCubo.getVertDownRightDownColor());
		vertici.Add(m_StatoCubo.getVertDownLeftUpColor());
		vertici.Add(m_StatoCubo.getVertDownLeftDownColor());

		int contSpigRosso, contSpigArancione, contSpigVerde, contSpigBlu, contSpigBianco, contSpigGiallo;
		contSpigRosso=contSpigArancione=contSpigVerde=contSpigBlu=contSpigBianco=contSpigGiallo=0;

		int contVertRosso, contVertArancione, contVertVerde, contVertBlu, contVertBianco, contVertGiallo;
		contVertRosso=contVertArancione=contVertVerde=contVertBlu=contVertBianco=contVertGiallo=0;

		for(int i=0;i<spigoli.Count;i++){
			if (m_GameManager.ColorCompare (spigoli [i], m_StatoCubo.getCentFrontColor ())) {
				contSpigRosso++;
			} else if (m_GameManager.ColorCompare (spigoli [i], m_StatoCubo.getCentBackColor ())) {
				contSpigArancione++;
			} else if (m_GameManager.ColorCompare (spigoli [i], m_StatoCubo.getCentLeftColor ())) {
				contSpigVerde++;
			} else if (m_GameManager.ColorCompare (spigoli [i], m_StatoCubo.getCentRightColor ())) {
				contSpigBlu++;
			} else if (m_GameManager.ColorCompare (spigoli [i], m_StatoCubo.getCentUpColor ())) {
				contSpigBianco++;
			} else if (m_GameManager.ColorCompare (spigoli [i], m_StatoCubo.getCentDownColor ())) {
				contSpigGiallo++;
			}


			if (m_GameManager.ColorCompare (vertici [i], m_StatoCubo.getCentFrontColor ())) {
				contVertRosso++;
			} else if (m_GameManager.ColorCompare (vertici [i], m_StatoCubo.getCentBackColor ())) {
				contVertArancione++;
			} else if (m_GameManager.ColorCompare (vertici [i], m_StatoCubo.getCentLeftColor ())) {
				contVertVerde++;
			} else if (m_GameManager.ColorCompare (vertici [i], m_StatoCubo.getCentRightColor ())) {
				contVertBlu++;
			} else if (m_GameManager.ColorCompare (vertici [i], m_StatoCubo.getCentUpColor ())) {
				contVertBianco++;
			} else if (m_GameManager.ColorCompare (vertici [i], m_StatoCubo.getCentDownColor ())) {
				contVertGiallo++;
			}
		}

		if (!(contSpigRosso == 4 && contVertRosso == 4 &&
		   contSpigArancione == 4 && contVertArancione == 4 &&
		   contSpigVerde == 4 && contVertVerde == 4 &&
		   contSpigBlu == 4 && contVertBlu == 4 &&
		   contSpigBianco == 4 && contVertBianco == 4 &&
		   contSpigGiallo == 4 && contVertGiallo == 4)) {
			m_HelpMeTutor.FineCalcolo (false);
			return;
		}

		//INIZIO RISOLUZIONE

		FileManager.setFilename ("HelpMeSaveFile");
		FileManager.salvaSuFile ();
		m_Risolvi = true;
		m_GameManager.ResetMosseEseguite ();
		m_Statistiche.TimeReset ();
		m_Animatore.SetStatoStoRisolvendo (true);
	}
}
