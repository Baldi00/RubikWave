using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.PostProcessing;
using UnityEngine.SceneManagement;

public class ScrittaMenuPrincipale : MonoBehaviour {
	
	[SerializeField]
	protected string mInfoString;

	protected Text mInfoOggetto;
	protected Text mMioTesto;

	protected GameManager mGameManager;
	protected InputManager mInputManager;
	protected MainMenuManager mMainMenuManager;

	protected GameObject mMenuOpzioni;
	protected GameObject mMenuControlli;
	protected GameObject mMenuPrincipale;
	protected GameObject mMainMenuContainer;

	protected GameObject mContinua;

	public void Start(){
		mMioTesto = GetComponent<Text> ();
		mGameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find ("GameManager").GetComponent<InputManager> ();
		mMainMenuManager = GameObject.Find ("GameManager").GetComponent<MainMenuManager> ();
		mMenuOpzioni = mMainMenuManager.GetMenuOpzioni ();
		mMenuControlli = mMainMenuManager.GetMenuControlli ();
		mMenuPrincipale = mMainMenuManager.GetMenuPrincipale ();
		mMainMenuContainer = mMainMenuManager.GetMainMenuContainer ();
		mInfoOggetto = mMainMenuManager.GetInfoVarieMenuPrincipale().GetComponent<Text> ();
		mContinua = mMainMenuManager.GetContinua ();
	}

	public void OnMouseEnter(){
		transform.localScale = new Vector3 (1.1f, 1.1f, 1f);
		Color attivato = new Color ();
		ColorUtility.TryParseHtmlString ("#00FFFFFF", out attivato);
		mMioTesto.color = attivato;
	}

	public void OnMouseOver(){

		mInfoOggetto.text = mInfoString;
			

		if (mInputManager.IsLeftMousePressed() && name.Equals ("Esci")) {
			if (!mMainMenuManager.GetFirtsStart()) {
				FileManager.salvaSuFile ();
			}
			Application.Quit ();
		}

		if (mInputManager.IsLeftMousePressed() && name.Equals ("Continua")) {
			mMainMenuManager.SetFirtsStart(false);
			mGameManager.SetCameraFreeEnabled(true);
			mMainMenuContainer.SetActive (false);
			mGameManager.ToggleGameRunning ();
			OnMouseExit ();
		}

		if (mInputManager.IsLeftMousePressed() && name.Equals ("NuovaPartita")) {

			Color attivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFFFF", out attivato);
			mContinua.GetComponent<Text> ().color = attivato;
			mContinua.GetComponent<BoxCollider> ().enabled = true;

			mGameManager.ResetCubo ();
			mGameManager.ResetMosseEseguite ();
			mGameManager.ResetTimer ();

			mMainMenuManager.SetFirtsStart(false);
			mGameManager.SetCameraFreeEnabled(true);
			mMainMenuContainer.SetActive (false);
			mGameManager.ToggleGameRunning ();
			OnMouseExit ();
		}

		if (mInputManager.IsLeftMousePressed() && name.Equals ("Aiutami")) {
			if (!mMainMenuManager.GetFirtsStart ()) {
				FileManager.salvaSuFile ();
			}
			ThroughScenesParameters.setSceneToLoad(1);
			SceneManager.LoadScene ("LoadingScreen", LoadSceneMode.Single);
		}

		if (mInputManager.IsLeftMousePressed() && name.Equals ("Opzioni")) {
			mMenuOpzioni.SetActive (true);
			mMenuPrincipale.SetActive (false);
			OnMouseExit ();
		}

		if (mInputManager.IsLeftMousePressed() && name.Equals ("Controlli")) {
			mMenuControlli.SetActive (true);
			mMenuPrincipale.SetActive (false);
			OnMouseExit ();
		}

		if (mInputManager.IsLeftMousePressed() && name.Equals ("Indietro")) {
			mMenuPrincipale.SetActive (true);
			mMenuOpzioni.SetActive (false);
			mMenuControlli.SetActive (false);
			OnMouseExit ();
		}
	}

	public void OnMouseExit(){

		transform.localScale = new Vector3 (1f, 1f, 1f);
		mInfoOggetto.text = "";
		Color disattivato = new Color ();
		ColorUtility.TryParseHtmlString ("#00CAFFFF", out disattivato);
		mMioTesto.color = disattivato;
	}
}
