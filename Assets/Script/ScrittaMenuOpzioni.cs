using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ScrittaMenuOpzioni : ScrittaMenuPrincipale {
	
	private bool mAcceso = false;

	private ScrittaMenuOpzioni mScrittaAlto, mScrittaMedio, mScrittaBasso, mVsyncOn, mVsyncOff, mScrittaSuoniOn, mScrittaSuoniOff;

	new void Start() {
		base.Start ();
		mScrittaAlto = mMainMenuManager.GetAlto().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaMedio = mMainMenuManager.GetMedio().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaBasso = mMainMenuManager.GetBasso().GetComponent<ScrittaMenuOpzioni> ();
		mVsyncOn = mMainMenuManager.GetVsOn().GetComponent<ScrittaMenuOpzioni> ();
		mVsyncOff = mMainMenuManager.GetVsOff().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaSuoniOn = mMainMenuManager.GetSuoniOn().GetComponent<ScrittaMenuOpzioni> ();
		mScrittaSuoniOff = mMainMenuManager.GetSuoniOff().GetComponent<ScrittaMenuOpzioni> ();
		mInputManager = GameObject.Find ("GameManager").GetComponent<InputManager> ();
	}

	new void OnMouseOver(){

		mInfoOggetto.text = mInfoString;

		if (mInputManager.IsLeftMousePressed()){
			switch (name) {
			case "Alto":
				DisabilitaTuttiPulsantiGrafica ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetAlto ();
				break;
			case "Medio":
				DisabilitaTuttiPulsantiGrafica ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetMedio ();
				break;
			case "Basso":
				DisabilitaTuttiPulsantiGrafica ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetBasso ();
				break;
			case "Vs_On":
				DisabilitaTuttiPulsantiGraficaVsync ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetVsyncOn ();
				break;
			case "Vs_Off":
				DisabilitaTuttiPulsantiGraficaVsync ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetVsyncOff ();
				break;
			case "SuoniOn":
				DisabilitaTuttiPulsantiSuono ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetSuoniOn ();
				break;
			case "SuoniOff":
				DisabilitaTuttiPulsantiSuono ();
				mAcceso = true;
				mGameManager.GetComponent<SettingsManager> ().SetSuoniOff ();
				break;
			case "Indietro":
				mMenuPrincipale.SetActive (true);
				mMenuOpzioni.SetActive (false);
				mMenuControlli.SetActive (false);
				OnMouseExit ();
				break;
			}
		}
	}

	public void Update(){
		if (mAcceso) {
			OnMouseEnter ();
		}
	}

	public void SetAcceso(bool value){
		mAcceso = value;
	}

	public void DisabilitaTuttiPulsantiGrafica(){
		mScrittaAlto.SetAcceso (false);
		mScrittaMedio.SetAcceso (false);
		mScrittaBasso.SetAcceso (false);
		mScrittaAlto.OnMouseExit();
		mScrittaMedio.OnMouseExit();
		mScrittaBasso.OnMouseExit();
	}

	public void DisabilitaTuttiPulsantiGraficaVsync(){
		mVsyncOn.SetAcceso (false);
		mVsyncOff.SetAcceso (false);
		mVsyncOn.OnMouseExit();
		mVsyncOff.OnMouseExit();
	}

	public void DisabilitaTuttiPulsantiSuono(){
		mScrittaSuoniOn.SetAcceso (false);
		mScrittaSuoniOff.SetAcceso (false);
		mScrittaSuoniOn.OnMouseExit();
		mScrittaSuoniOff.OnMouseExit();
	}
}
