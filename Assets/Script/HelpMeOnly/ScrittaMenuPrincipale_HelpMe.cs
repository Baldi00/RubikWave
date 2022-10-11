using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrittaMenuPrincipale_HelpMe : ScrittaMenuPrincipale {

    public new void OnMouseOver(){

		mInfoOggetto.text = mInfoString;


		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Esci")) {
			Application.Quit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Continua")) {
			mGameManager.SetCameraFreeEnabled(true);
			mMainMenuContainer.SetActive(false);
			mGameManager.ToggleGameRunning();
			OnMouseExit();
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
			mMenuOpzioni.SetActive (true);
			mMenuPrincipale.SetActive (false);
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Controlli")) {
			mMenuControlli.SetActive (true);
			mMenuPrincipale.SetActive (false);
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Indietro")) {
			mMenuPrincipale.SetActive (true);
			mMenuOpzioni.SetActive (false);
			mMenuControlli.SetActive (false);
			OnMouseExit ();
		}
	}
}
