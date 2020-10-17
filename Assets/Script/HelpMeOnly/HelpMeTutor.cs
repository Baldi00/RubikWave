using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMeTutor : MonoBehaviour {

	[SerializeField]
	private CalcolaProssimaPrecedenteController m_CalProPreController;

	[SerializeField]
	private Animatore m_Animatore;

	[SerializeField]
	private int m_VelocitaEsecuzione;

	[SerializeField]
	private GameObject m_CalcError;

	[SerializeField]
	private InformazioniInGame m_InformazioniInGame;

	private List<int> m_Mosse;
	private int m_Index = 0;

	void Start() {
		m_Mosse = new List<int> ();
	}

	public void AggiungiMosse(int[] mosse) {
		for (int i = 0; i < mosse.Length; i++) {
			m_Mosse.Add (mosse [i]);
		}
	}

	public void FineCalcolo(bool riuscito){
		if (riuscito) {
			OttimizzaMosse ();
			m_InformazioniInGame.SetMosseEseguite (m_Mosse.Count);
			m_CalProPreController.CambiaModalita ();
			gameObject.GetComponent<GameManager_HelpMe>().FaseSceltaColoriCompletata ();
			gameObject.GetComponent<GameManager_HelpMe>().ControllaSeHoVinto ();
		} else {
			m_Mosse.Clear ();
			setCalcErrorVisibility (true);
		}
	}

	public void ProssimaMossa(){
		if (m_Animatore.isFermo() && m_Index < m_Mosse.Count) {
			m_Animatore.EseguiPiuMosse (new int[]{ (int)m_Mosse[m_Index] }, m_VelocitaEsecuzione);
			m_Index++;
			m_InformazioniInGame.AddMossaEseguitaDalGiocatore ();
		}

		if (m_Index == m_Mosse.Count) {
			gameObject.GetComponent<GameManager_HelpMe>().ControllaSeHoVinto ();
		}
	}

	public void MossaPrecedente(){

		if (m_Animatore.isFermo() && m_Index > 0) {
			m_Index--;
			if (m_Mosse [m_Index] % 2 == 0) {
				m_Animatore.EseguiPiuMosse (new int[]{ m_Mosse [m_Index] - 1 }, m_VelocitaEsecuzione);
			} else {
				m_Animatore.EseguiPiuMosse (new int[]{ m_Mosse [m_Index] + 1 }, m_VelocitaEsecuzione);
			}
			m_InformazioniInGame.SubMossaEseguitaDalGiocatore ();

		}

		if (m_Index == m_Mosse.Count-1) {
			gameObject.GetComponent<GameManager_HelpMe>().ControllaSeHoVinto ();
		}
	}

	public void setCalcErrorVisibility(bool visibility){
		m_CalcError.SetActive (visibility);
	}

	public void OttimizzaMosse(){
		
		for(int j = 0; j < 3; j++){
			
			//Rimuove 4 mosse in una direzione
			for (int i = 0; i < m_Mosse.Count-3; i++) {
				int mossa = m_Mosse [i];
				if (m_Mosse [i] == m_Mosse [i + 1] && m_Mosse [i + 1] == m_Mosse [i + 2] && m_Mosse [i + 2] == m_Mosse [i + 3]) {
					m_Mosse.RemoveRange (i, 4);
				}
			}

			//Rimuove 3 mosse in una direzione, una nella direzione opposta
			for (int i = 0; i < m_Mosse.Count-2; i++) {
				int mossa = m_Mosse [i];
				if (m_Mosse [i] == m_Mosse [i + 1] && m_Mosse [i + 1] == m_Mosse [i + 2]) {
					m_Mosse.RemoveRange (i, 3);
					if (mossa % 2 == 0) {
						m_Mosse.Insert (i, mossa - 1);
					} else {
						m_Mosse.Insert (i, mossa + 1);
					}
				}
			}

			//Rimuove mossa e poi subito la sua opposta
			for (int i = 0; i < m_Mosse.Count-1; i++) {
				if ((m_Mosse [i] % 2 == 0 && m_Mosse [i] == m_Mosse [i + 1] + 1) || (m_Mosse [i] % 2 != 0 && m_Mosse [i] == m_Mosse [i + 1] - 1)) {
					m_Mosse.RemoveRange (i, 2);
				}
			}

		}
	}
}