using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformazioniInGame : StatisticheInGame {

	private int mosseEseguiteDalGiocatore = 0;

	void Update () {
		int mosseEseguite = m_GameManager.GetNumMosseEseguite();
		m_NumMosse.text = mosseEseguiteDalGiocatore + " / " + mosseEseguite;
	}

	public void AddMossaEseguitaDalGiocatore(){
		mosseEseguiteDalGiocatore++;
	}

	public void SubMossaEseguitaDalGiocatore(){
		mosseEseguiteDalGiocatore--;
	}

	public void SetMosseEseguite(int mosse){
		m_GameManager.SetNumMosseEseguite (mosse);
	}
}
