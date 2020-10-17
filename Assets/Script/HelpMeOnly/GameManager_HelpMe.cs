using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_HelpMe : GameManager {

	[SerializeField]
	private GameObject m_InserisciColoriInfo;

	bool m_PrimaModifica = false;
	bool m_FaseSceltaColori = true;

	Color[] colors;

	public Color getNextOrPreviousColorByActualColor(Color c, bool prev){

		if (!m_PrimaModifica) {
			m_InserisciColoriInfo.SetActive (false);
			m_PrimaModifica = true;
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
		m_StatoCubo = GetComponent<StatoCubo> ();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		m_GameRunning = true;
		FileManager.caricaOpzioni ();
	}

	public bool isFaseSceltaColori(){
		return m_FaseSceltaColori;
	}

	public void FaseSceltaColoriCompletata(){
		m_FaseSceltaColori = false;
	}
}
