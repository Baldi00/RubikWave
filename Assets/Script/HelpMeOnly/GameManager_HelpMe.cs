using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_HelpMe : GameManager {

	[SerializeField]
	private GameObject mInserisciColoriInfo;

	bool mPrimaModifica = false;
	bool mFaseSceltaColori = true;

	Color[] colors;

	public Color getNextOrPreviousColorByActualColor(Color c, bool prev){

		if (!mPrimaModifica) {
			mInserisciColoriInfo.SetActive (false);
			mPrimaModifica = true;
		}

		colors = new[] {GameObject.Find ("CentFront").GetComponent<Renderer>().material.color, 
			GameObject.Find ("CentBack").GetComponent<Renderer>().material.color, 
			GameObject.Find ("CentLeft").GetComponent<Renderer>().material.color, 
			GameObject.Find ("CentRight").GetComponent<Renderer>().material.color, 
			GameObject.Find ("CentUp").GetComponent<Renderer>().material.color, 
			GameObject.Find ("CentDown").GetComponent<Renderer>().material.color};

		for (int i = 0; i < colors.Length; i++) {
			if (ColorCompare (colors [i], c)) {
				if (prev) {
					if (i == 0) {
						return colors [colors.Length - 1];
					} else {
						return colors [--i];
					}
				} else {
					if (i == colors.Length - 1) {
						return colors [0];
					} else {
						return colors [++i];
					}
				}
			}
		}
		return new Color(0f,0f,0f);
	}

	void Start () {
		mStatoCubo = GetComponent<StatoCubo> ();
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		mGameRunning = true;
		FileManager.caricaOpzioni ();
	}

	public bool isFaseSceltaColori(){
		return mFaseSceltaColori;
	}

	public void FaseSceltaColoriCompletata(){
		mFaseSceltaColori = false;
	}
}
