using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

public class ScrittaMenuPrincipale : MonoBehaviour {
	[SerializeField]
	protected string m_InfoString;

	[SerializeField]
	protected Text m_InfoOggetto;
	protected Text m_MioTesto;

	[SerializeField]
	protected GameObject m_GameManager;

	[SerializeField]
	protected GameObject m_MenuOpzioni;

	[SerializeField]
	protected GameObject m_MenuControlli;

	[SerializeField]
	protected GameObject m_MenuPrincipale;

	[SerializeField]
	protected GameObject m_Continua;

	public void Start(){
		m_MioTesto = GetComponent<Text> ();
	}

	public void OnMouseEnter(){
		transform.localScale = new Vector3 (1.1f, 1.1f, 1f);
		Color attivato = new Color ();
		ColorUtility.TryParseHtmlString ("#00FFFFFF", out attivato);
		m_MioTesto.color = attivato;
	}

	public void OnMouseOver(){

		m_InfoOggetto.text = m_InfoString;
			

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Esci")) {
			if (!m_MenuPrincipale.GetComponent<MenuPrincipale>().GetFirtsStart()) {
				FileManager.salvaSuFile ();
			}
			Application.Quit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Continua")) {
			m_MenuPrincipale.GetComponent<MenuPrincipale>().SetFirtsStart(false);
			m_MenuPrincipale.SetActive (false);
			m_GameManager.GetComponent<GameManager> ().ToggleGameRunning ();
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("NuovaPartita")) {

			Color attivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFFFF", out attivato);
			m_Continua.GetComponent<Text> ().color = attivato;
			m_Continua.GetComponent<BoxCollider> ().enabled = true;

			m_GameManager.GetComponent<GameManager> ().ResetCubo ();
			m_GameManager.GetComponent<GameManager> ().ResetMosseEseguite ();
			m_GameManager.GetComponent<GameManager> ().ResetTimer ();

			m_MenuPrincipale.GetComponent<MenuPrincipale>().SetFirtsStart(false);
			m_MenuPrincipale.SetActive (false);
			m_GameManager.GetComponent<GameManager> ().ToggleGameRunning ();
			OnMouseExit ();
		}

		if (Input.GetKeyDown (KeyCode.Mouse0) && name.Equals ("Aiutami")) {
			if (!m_MenuPrincipale.GetComponent<MenuPrincipale> ().GetFirtsStart ()) {
				FileManager.salvaSuFile ();
			}
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

	public void OnMouseExit(){

		transform.localScale = new Vector3 (1f, 1f, 1f);
		m_InfoOggetto.text = "";
		Color disattivato = new Color ();
		ColorUtility.TryParseHtmlString ("#00CAFFFF", out disattivato);
		m_MioTesto.color = disattivato;
	}
}
