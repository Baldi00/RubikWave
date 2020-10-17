using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcolaProssimaPrecedenteController : MonoBehaviour {

	[SerializeField]
	private GameObject m_Calcola, m_Prossima, m_Precedente;

	[SerializeField]
	private GameObject m_SfondoPrecedente;

	[SerializeField]
	protected Text m_InfoOggetto;

	[SerializeField]
	protected GameObject m_Congratulazioni;

	[SerializeField]
	protected HelpMeTutor m_HelpMeTutor;

	protected GameManager_HelpMe m_GameManagerHelpMe;
	protected Animatore m_Animatore;
	protected AI_HelpMe m_AIHelpMe;

	protected StatisticheInGame m_Statistiche;

	void Start () {
		m_GameManagerHelpMe = GameObject.Find ("GameManager").GetComponent<GameManager_HelpMe> ();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore> ();
		m_AIHelpMe = GameObject.Find ("AI").GetComponent<AI_HelpMe> ();
		m_Statistiche = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame> ();
	}

	void OnMouseEnter(){
		Color azzurroChiaro = new Color ();
		ColorUtility.TryParseHtmlString ("#00FFFFFF", out azzurroChiaro);
		switch (name) {
		case "Calcola":
			m_Calcola.GetComponent<Text>().color = azzurroChiaro;
			break;
		case "Prossima":
			m_Prossima.GetComponent<Text>().color = azzurroChiaro;
			break;
		case "Precedente":
			m_Precedente.GetComponent<Text>().color = azzurroChiaro;
			break;
		}
	}

	void OnMouseOver(){

		switch (name) {
		case "Calcola":
			m_InfoOggetto.text = "Calcola le mosse e inizia a risolvere";
			break;
		}

		if (Input.GetKey (KeyCode.Mouse0) && m_GameManagerHelpMe.IsGameRunning () && m_Animatore.isFermo ()) {
			if(name.Equals("Calcola")) {
				m_AIHelpMe.HelpMeCalcola ();
				m_InfoOggetto.text = "";
			} else if (name.Equals("Prossima")) {
				m_HelpMeTutor.ProssimaMossa ();
			} else if (name.Equals("Precedente")) {
				m_HelpMeTutor.MossaPrecedente ();
			}
		}
	}

	void OnMouseExit(){
		Color azzurro = new Color ();
		ColorUtility.TryParseHtmlString ("#00CAFFFF", out azzurro);

		switch (name) {
		case "Calcola":
			m_Calcola.GetComponent<Text>().color = azzurro;
			break;
		case "Prossima":
			m_Prossima.GetComponent<Text>().color = azzurro;
			break;
		case "Precedente":
			m_Precedente.GetComponent<Text>().color = azzurro;
			break;
		}

		m_InfoOggetto.text = "";
	}

	public void CambiaModalita(){
		m_Calcola.SetActive(false);
		m_Prossima.SetActive(true);
		m_Precedente.SetActive(true);
		m_SfondoPrecedente.SetActive (true);
	}
}
