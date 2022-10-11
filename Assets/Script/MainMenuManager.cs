using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

	protected GameManager mGameManager;
	protected InputManager mInputManager;

	protected GameObject mMainMenuContainer, mPrincipale, mControlli, mOpzioni;
	protected GameObject mBlackFadeIn;

	protected bool mFirstStart = true;

	void Awake() {
		mGameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find ("GameManager").GetComponent<InputManager> ();
		mMainMenuContainer = GameObject.Find ("MenuPrincipale");
		mPrincipale = GameObject.Find ("MenuPrincipalePrincipale");
		mControlli = GameObject.Find ("MenuPrincipaleControlli");
		mOpzioni = GameObject.Find ("MenuPrincipaleOpzioni");
		mControlli.SetActive (false);
		mOpzioni.SetActive (false);
		mBlackFadeIn = GameObject.Find ("BlackFadeIn");
	}

	void Update () {
		
		if (mInputManager.IsEscapePressed () && mGameManager.IsGameRunning ()) {
			
			mGameManager.SetCameraFreeEnabled (false);
			mGameManager.ToggleGameRunning ();
			mMainMenuContainer.SetActive (true);
			mPrincipale.SetActive (true);

		} else { //I'm already in MainMenu

			if (mInputManager.IsEscapePressed () && mFirstStart) {
				mControlli.SetActive (false);
				mOpzioni.SetActive (false);
				mPrincipale.SetActive (true);
			}


			if (mInputManager.IsEscapePressed () && !mFirstStart) {

				if (mPrincipale.activeSelf) {
					mGameManager.ToggleGameRunning ();
					mGameManager.GetComponent<GameManager> ().SetCameraFreeEnabled (true);
					mMainMenuContainer.SetActive (false);
				}

				mControlli.SetActive (false);
				mOpzioni.SetActive (false);
				mPrincipale.SetActive (true);
			}
		}
	}

	public void SetFirtsStart(bool firstStart){
		mFirstStart = firstStart;
		mBlackFadeIn.SetActive (false);
	}

	public bool GetFirtsStart(){
		return mFirstStart;
	}

	public GameObject GetMainMenuContainer (){
		return mMainMenuContainer;
	}

	public GameObject GetMenuPrincipale (){
		return mPrincipale;
	}

	public GameObject GetMenuControlli (){
		return mControlli;
	}

	public GameObject GetMenuOpzioni (){
		return mOpzioni;
	}

	public GameObject GetContinua (){
		return Utilities.GetGameObjectChildByName(mPrincipale, "Continua");
	}

	public GameObject GetAlto (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "Alto");
	}

	public GameObject GetMedio (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "Medio");
	}

	public GameObject GetBasso (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "Basso");
	}

	public GameObject GetVsOn (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "Vs_On");
	}

	public GameObject GetVsOff (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "Vs_Off");
	}

	public GameObject GetSuoniOn (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "SuoniOn");
	}

	public GameObject GetSuoniOff (){
		return Utilities.GetGameObjectChildByName(mOpzioni, "SuoniOff");
	}

	public GameObject GetInfoVarieMenuPrincipale() {
		return GameObject.Find("InfoVarieMenuPrincipale");
	}

	public void SetMainMenuVisibility (bool visibility) {
		mPrincipale.SetActive (visibility);
	}
}
