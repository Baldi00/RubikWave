using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class ScrittaMenuOpzioni : ScrittaMenuPrincipale {

	[SerializeField]
	private bool m_Acceso;

	[SerializeField]
	private ScrittaMenuOpzioni m_ScrittaAlto, m_ScrittaMedio, m_ScrittaBasso, m_VsyncOn, m_VsyncOff, m_ScrittaSuoniOn, m_ScrittaSuoniOff;

	void OnMouseOver(){

		m_InfoOggetto.text = m_InfoString;

		if (Input.GetKeyDown (KeyCode.Mouse0)){
			switch (name) {
			case "Alto":
				DisabilitaTuttiPulsantiGrafica ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetAlto ();
				break;
			case "Medio":
				DisabilitaTuttiPulsantiGrafica ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetMedio ();
				break;
			case "Basso":
				DisabilitaTuttiPulsantiGrafica ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetBasso ();
				break;
			case "Vs_On":
				DisabilitaTuttiPulsantiGraficaVsync ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetVsyncOn ();
				break;
			case "Vs_Off":
				DisabilitaTuttiPulsantiGraficaVsync ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetVsyncOff ();
				break;
			case "SuoniOn":
				DisabilitaTuttiPulsantiSuono ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetSuoniOn ();
				break;
			case "SuoniOff":
				DisabilitaTuttiPulsantiSuono ();
				m_Acceso = true;
				m_GameManager.GetComponent<SettingsManager> ().SetSuoniOff ();
				break;
			case "Indietro":
				m_MenuPrincipale.SetActive (true);
				m_MenuOpzioni.SetActive (false);
				m_MenuControlli.SetActive (false);
				OnMouseExit ();
				break;
			}
		}
	}

	public void Update(){
		if (m_Acceso) {
			OnMouseEnter ();
		}
	}

	public void SetAcceso(bool value){
		m_Acceso = value;
	}

	public void DisabilitaTuttiPulsantiGrafica(){
		m_ScrittaAlto.SetAcceso (false);
		m_ScrittaMedio.SetAcceso (false);
		m_ScrittaBasso.SetAcceso (false);
		m_ScrittaAlto.OnMouseExit();
		m_ScrittaMedio.OnMouseExit();
		m_ScrittaBasso.OnMouseExit();
	}

	public void DisabilitaTuttiPulsantiGraficaVsync(){
		m_VsyncOn.SetAcceso (false);
		m_VsyncOff.SetAcceso (false);
		m_VsyncOn.OnMouseExit();
		m_VsyncOff.OnMouseExit();
	}

	public void DisabilitaTuttiPulsantiSuono(){
		m_ScrittaSuoniOn.SetAcceso (false);
		m_ScrittaSuoniOff.SetAcceso (false);
		m_ScrittaSuoniOn.OnMouseExit();
		m_ScrittaSuoniOff.OnMouseExit();
	}
}
