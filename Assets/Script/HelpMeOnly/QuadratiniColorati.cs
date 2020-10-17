using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadratiniColorati : MonoBehaviour {
	
	[SerializeField]
	private MovimentoCamera m_Camera;

	[SerializeField]
	GameManager_HelpMe m_GameManagerHelpMe;

	private Animatore m_Animatore;

	void Start(){
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore> ();
	}

	void Update () {
		switch (tag) {
		case "Front":
			if (m_GameManagerHelpMe.isFaseSceltaColori() && (m_Camera.GetPosizione () == 1 || m_Camera.GetPosizione () == 4 || m_Camera.GetPosizione () == 5 || m_Camera.GetPosizione () == 8))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Back":
			if (m_GameManagerHelpMe.isFaseSceltaColori() && (m_Camera.GetPosizione () == 2 || m_Camera.GetPosizione () == 3 || m_Camera.GetPosizione () == 6 || m_Camera.GetPosizione () == 7))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Left":
			if (m_GameManagerHelpMe.isFaseSceltaColori() && (m_Camera.GetPosizione () == 1 || m_Camera.GetPosizione () == 2 || m_Camera.GetPosizione () == 5 || m_Camera.GetPosizione () == 6))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Right":
			if (m_GameManagerHelpMe.isFaseSceltaColori() && (m_Camera.GetPosizione () == 3 || m_Camera.GetPosizione () == 4 || m_Camera.GetPosizione () == 7 || m_Camera.GetPosizione () == 8))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Up":
			if (m_GameManagerHelpMe.isFaseSceltaColori() && (m_Camera.GetPosizione () == 1 || m_Camera.GetPosizione () == 2 || m_Camera.GetPosizione () == 3 || m_Camera.GetPosizione () == 4))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		case "Down":
			if (m_GameManagerHelpMe.isFaseSceltaColori() && (m_Camera.GetPosizione () == 5 || m_Camera.GetPosizione () == 6 || m_Camera.GetPosizione () == 7 || m_Camera.GetPosizione () == 8))
				GetComponent<BoxCollider>().enabled = true;
			else
				GetComponent<BoxCollider>().enabled = false;
			break;
		}
	}

	void OnMouseOver() {
		if (Input.GetKeyDown (KeyCode.Mouse0) && m_GameManagerHelpMe.IsGameRunning () && m_Animatore.isFermo()) {
			GetComponent<Renderer> ().material.color = m_GameManagerHelpMe.getNextOrPreviousColorByActualColor (GetComponent<Renderer> ().material.color, true);
		} else if (Input.GetKeyDown (KeyCode.Mouse1)) {
			GetComponent<Renderer> ().material.color = m_GameManagerHelpMe.getNextOrPreviousColorByActualColor (GetComponent<Renderer> ().material.color, false);
		}
	}
}
