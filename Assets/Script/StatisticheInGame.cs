using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatisticheInGame : MonoBehaviour {
	protected float secondi = 0f;
	protected int minuti = 0;
	protected int ore = 0;

	[SerializeField]
	protected Text m_NumMosse;

	[SerializeField]
	protected Text m_TempoTrascorso;

	protected GameManager m_GameManager;
	protected Animatore m_Animatore;

	// Use this for initialization
	void Start () {
		m_GameManager = GameObject.Find ("GameManager").GetComponent<GameManager>();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
	}
	
	// Update is called once per frame
	void Update () {
		
		int mosseEseguite = m_GameManager.GetNumMosseEseguite();

		if (mosseEseguite < 10) {
			m_NumMosse.text = "" + mosseEseguite;
		} else if (mosseEseguite < 100) {
			m_NumMosse.text = "" + mosseEseguite.ToString ().Insert (1, " ");
		} else if (mosseEseguite < 1000) {
			m_NumMosse.text = "" + mosseEseguite.ToString ().Insert (2, " ").Insert (1, " ");
		} else if (mosseEseguite < 10000) {
			m_NumMosse.text = "" + mosseEseguite.ToString ().Insert (3, " ").Insert (2, " ").Insert (1, " ");
		} else if (mosseEseguite < 100000) {
			m_NumMosse.text = "" + mosseEseguite.ToString ().Insert (4, " ").Insert (3, " ").Insert (2, " ").Insert (1, " ");
		} else {
			m_GameManager.ResetMosseEseguite ();
		}

		if(ore<10)
			m_TempoTrascorso.text = "0 " + ore + " : ";
		else
			m_TempoTrascorso.text = "" + ore.ToString().Insert(1," ") + " : ";
		if(minuti<10)
			m_TempoTrascorso.text += "0 " + minuti + " : ";
		else
			m_TempoTrascorso.text += "" + minuti.ToString().Insert(1," ") + " : ";
		if(secondi<10)
			m_TempoTrascorso.text += "0 " + (int)secondi;
		else
			m_TempoTrascorso.text += "" + ((int)secondi).ToString().Insert(1," ");
		
		
		if (m_GameManager.IsGameRunning () && !m_Animatore.StoMescolando()) {
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
