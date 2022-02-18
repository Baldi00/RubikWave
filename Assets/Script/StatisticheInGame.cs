using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticheInGame : MonoBehaviour {
	protected float secondi = 0f;
	protected int minuti = 0;
	protected int ore = 0;

	protected Text mNumMosse;
	protected Text mTempoTrascorso;

	protected GameManager mGameManager;
	protected Animatore mAnimatore;

	// Use this for initialization
	void Start () {
		mGameManager = GameObject.Find ("GameManager").GetComponent<GameManager>();
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();

		GameObject ui = Utilities.GetGameObjectChildByName (gameObject, "UI");
		mNumMosse = Utilities.GetGameObjectChildByName (ui, "NumMosse").GetComponent<Text> ();
		mTempoTrascorso = Utilities.GetGameObjectChildByName (ui, "TempoTrascorso").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		int mosseEseguite = mGameManager.GetNumMosseEseguite();

		if (mosseEseguite < 10) {
			mNumMosse.text = "" + mosseEseguite;
		} else if (mosseEseguite < 100) {
			mNumMosse.text = "" + mosseEseguite.ToString ().Insert (1, " ");
		} else if (mosseEseguite < 1000) {
			mNumMosse.text = "" + mosseEseguite.ToString ().Insert (2, " ").Insert (1, " ");
		} else if (mosseEseguite < 10000) {
			mNumMosse.text = "" + mosseEseguite.ToString ().Insert (3, " ").Insert (2, " ").Insert (1, " ");
		} else if (mosseEseguite < 100000) {
			mNumMosse.text = "" + mosseEseguite.ToString ().Insert (4, " ").Insert (3, " ").Insert (2, " ").Insert (1, " ");
		} else {
			mGameManager.ResetMosseEseguite ();
		}

		if(ore<10)
			mTempoTrascorso.text = "0 " + ore + " : ";
		else
			mTempoTrascorso.text = "" + ore.ToString().Insert(1," ") + " : ";
		if(minuti<10)
			mTempoTrascorso.text += "0 " + minuti + " : ";
		else
			mTempoTrascorso.text += "" + minuti.ToString().Insert(1," ") + " : ";
		if(secondi<10)
			mTempoTrascorso.text += "0 " + (int)secondi;
		else
			mTempoTrascorso.text += "" + ((int)secondi).ToString().Insert(1," ");
		
		
		if (mGameManager.IsGameRunning () && !mAnimatore.StoMescolando()) {
			secondi += Time.deltaTime;
		}

		if (secondi >= 60) {
			minuti++;
			secondi = 0f;
		}

		if (minuti > 59) {
			ore++;
			minuti = 0;
		}

		if (ore > 99) {
			TimeReset ();
		}
	}

	public void TimeReset(){
		ore = 0;
		minuti = 0;
		secondi = 0f;
	}

	public int GetOre(){
		return ore;
	}

	public int GetMinuti(){
		return minuti;
	}

	public float GetSecondi(){
		return secondi;
	}

	public void SetOre(int newOre){
		ore = newOre;
	}

	public void SetMinuti(int newMinuti){
		minuti = newMinuti;
	}

	public void SetSecondi(float newSecondi){
		secondi = newSecondi;
	}
}
