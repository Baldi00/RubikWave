using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MescolaRisolviReset : MonoBehaviour {

	[SerializeField]
	private Text m_Mescola, m_Risolvi, m_Reset;

	[SerializeField]
	protected Text m_InfoOggetto;

	protected int m_Index = 0;

	[SerializeField]
	protected GameObject m_Congratulazioni;

	protected GameManager m_GameManager;
	protected Animatore m_Animatore;
	protected AI m_AI;

	protected StatisticheInGame m_Statistiche;

	void Start () {
		m_GameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore> ();
		m_AI = GameObject.Find ("AI").GetComponent<AI> ();
		m_Statistiche = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame> ();

		m_Mescola.enabled = true;
		m_Risolvi.enabled = false;
		m_Reset.enabled = false;

		switch (m_Index) {
		case 0:
			m_Mescola.enabled = true;
			break;
		case 1:
			m_Risolvi.enabled = true;
			break;
		case 2:
			m_Reset.enabled = true;
			break;
		}
	}

	void OnMouseEnter(){
		Color azzurroChiaro = new Color ();
		ColorUtility.TryParseHtmlString ("#00FFFFFF", out azzurroChiaro);
		m_Mescola.color = azzurroChiaro;
		m_Risolvi.color = azzurroChiaro;
		m_Reset.color = azzurroChiaro;
	}

	void OnMouseOver(){

		switch (m_Index) {
		case 0:
			m_InfoOggetto.text = "Mescola il cubo\nTASTO DESTRO DEL MOUSE PER CAMBIARE AZIONE";
			break;
		case 1:
			m_InfoOggetto.text = "Risolvi il cubo con intelligenza artificiale\nTASTO DESTRO DEL MOUSE PER CAMBIARE AZIONE";
			break;
		case 2:
			m_InfoOggetto.text = "Riporta il cubo allo stato iniziale\nTASTO DESTRO DEL MOUSE PER CAMBIARE AZIONE";
			break;
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && m_GameManager.IsGameRunning () && m_Animatore.isFermo ()) {
			if (m_Index == 0) {
				m_Statistiche.TimeReset ();
				m_GameManager.ResetMosseEseguite ();
				m_Congratulazioni.SetActive (false);
				m_AI.Reset ();

				int numMosseInizializzazione = m_GameManager.GetNumMosseInizializzazione ();
				int velocitaMescola = m_GameManager.GetVelocitaMescola ();

				int[] m_MosseInizializzazione = new int[numMosseInizializzazione];
				for (int index = 0; index < numMosseInizializzazione; index++) {
					m_MosseInizializzazione [index] = Random.Range (1, 13);
				}
				m_Animatore.SetStatoStoMescolando (true);
				m_Animatore.EseguiPiuMosse (m_MosseInizializzazione, velocitaMescola);

			} else if (m_Index == 1) {
				m_AI.Risolvi ();
			} else if (m_Index == 2) {
				m_Congratulazioni.SetActive (false);
				m_GameManager.ResetMosseEseguite ();
				m_Statistiche.TimeReset ();
				m_GameManager.ResetCubo ();
				m_AI.Reset ();
			}
		} else if (Input.GetKeyDown (KeyCode.Mouse1) && m_GameManager.IsGameRunning ()) {
			m_Index++;
			if (m_Index > 2) {
				m_Index = 0;
			}

			m_Mescola.enabled = false;
			m_Risolvi.enabled = false;
			m_Reset.enabled = false;

			switch (m_Index) {
			case 0:
				m_Mescola.enabled = true;
				break;
			case 1:
				m_Risolvi.enabled = true;
				break;
			case 2:
				m_Reset.enabled = true;
				break;
			}
		}
	}

	void OnMouseExit(){
		Color azzurro = new Color ();
		ColorUtility.TryParseHtmlString ("#00CAFFFF", out azzurro);
		m_Mescola.color = azzurro;
		m_Risolvi.color = azzurro;
		m_Reset.color = azzurro;
		m_InfoOggetto.text = "";
	}
}
