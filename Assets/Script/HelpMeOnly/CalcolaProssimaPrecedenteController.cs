using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalcolaProssimaPrecedenteController : MonoBehaviour {

	[SerializeField]
	private GameObject mCalcola, mProssima, mPrecedente;

	[SerializeField]
	private GameObject mSfondoPrecedente;

	[SerializeField]
	protected Text mInfoOggetto;

	[SerializeField]
	protected GameObject mCongratulazioni;

	[SerializeField]
	protected HelpMeTutor mHelpMeTutor;

	protected GameManager_HelpMe mGameManagerHelpMe;
	protected AnimationManager mAnimatore;
	protected AI_HelpMe mAIHelpMe;

	protected StatisticheInGame mStatistiche;

    void Start () {
		mGameManagerHelpMe = GameObject.Find ("GameManager").GetComponent<GameManager_HelpMe> ();
		mAnimatore = GameObject.Find ("GameManager").GetComponent<AnimationManager> ();
		mAIHelpMe = GameObject.Find ("AI").GetComponent<AI_HelpMe> ();
		mStatistiche = GameObject.Find ("CanvasInGameUI").GetComponent<StatisticheInGame> ();
	}

	void OnMouseEnter(){
		Color azzurroChiaro = new Color ();
		ColorUtility.TryParseHtmlString ("#00FFFFFF", out azzurroChiaro);
		switch (name) {
		case "Calcola":
			mCalcola.GetComponent<Text>().color = azzurroChiaro;
			break;
		case "Prossima":
			mProssima.GetComponent<Text>().color = azzurroChiaro;
			break;
		case "Precedente":
			mPrecedente.GetComponent<Text>().color = azzurroChiaro;
			break;
		}
	}

	void OnMouseOver(){

		switch (name) {
		case "Calcola":
			mInfoOggetto.text = "Calcola le mosse e inizia a risolvere";
			break;
		}

		if (Input.GetKey (KeyCode.Mouse0) && mGameManagerHelpMe.IsGameRunning () && mAnimatore.isFermo ()) {
			if(name.Equals("Calcola")) {
				mAIHelpMe.HelpMeCalcola ();
				mInfoOggetto.text = "";
			} else if (name.Equals("Prossima")) {
				mHelpMeTutor.ProssimaMossa ();
			} else if (name.Equals("Precedente")) {
				mHelpMeTutor.MossaPrecedente ();
			}
		}
	}

	void OnMouseExit(){
		Color azzurro = new Color ();
		ColorUtility.TryParseHtmlString ("#00CAFFFF", out azzurro);

		switch (name) {
		case "Calcola":
			mCalcola.GetComponent<Text>().color = azzurro;
			break;
		case "Prossima":
			mProssima.GetComponent<Text>().color = azzurro;
			break;
		case "Precedente":
			mPrecedente.GetComponent<Text>().color = azzurro;
			break;
		}

		mInfoOggetto.text = "";
	}

	public void CambiaModalita(){
		mCalcola.SetActive(false);
		mProssima.SetActive(true);
		mPrecedente.SetActive(true);
		mSfondoPrecedente.SetActive (true);
	}
}
