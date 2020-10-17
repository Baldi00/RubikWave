using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrittaMenuPrincipale_HelpMe : ScrittaMenuPrincipale {

	public void OnMouseOver(){

		m_InfoOggetto.text = m_InfoString;


		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Esci")) {
			Application.Quit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Continua")) {
			m_MenuPrincipale.SetActive (false);
			m_GameManager.GetComponent<GameManager_HelpMe> ().ToggleGameRunning ();
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("NuovaPartita")) {
			FileManager.salvaOpzioni ();
			ThroughScenesParameters.setSceneToLoad(0);
			SceneManager.LoadScene ("LoadingScreen", LoadSceneMode.Single);
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Aiutami")) {
			FileManager.salvaOpzioni ();
			ThroughScenesParameters.setSceneToLoad(1);
			SceneManager.LoadScene ("LoadingScreen", LoadSceneMode.Single);
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Opzioni")) {
			m_MenuOpzioni.SetActive (true);
			m_MenuPrincipale.SetActive (false);
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Controlli")) {
			m_MenuControlli.SetActive (true);
			m_MenuPrincipale.SetActive (false);
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Indietro")) {
			m_MenuPrincipale.SetActive (true);
			m_MenuOpzioni.SetActive (false);
			m_MenuControlli.SetActive (false);
			OnMouseExit ();
		}
	}
}
