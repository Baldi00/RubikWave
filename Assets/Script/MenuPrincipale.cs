using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipale : MonoBehaviour {

	[SerializeField]
	protected GameManager m_GameManager;

	[SerializeField]
	protected GameObject m_Principale, m_Controlli, m_Opzioni;

	[SerializeField]
	protected GameObject m_BlackFadeIn;

	protected bool m_FirstStart = true;

	void Update () {

		if (Input.GetKeyDown (KeyCode.Escape) && m_FirstStart) {
			m_Controlli.SetActive (false);
			m_Opzioni.SetActive (false);
			m_Principale.SetActive (true);
		}


		if (Input.GetKeyDown (KeyCode.Escape) && !m_FirstStart) {

			if (m_Principale.activeSelf) {
				m_GameManager.ToggleGameRunning ();
				m_GameManager.GetComponent<GameManager>().SetCameraFreeEnabled(true);
				gameObject.SetActive (false);
			}

			m_Controlli.SetActive (false);
			m_Opzioni.SetActive (false);
			m_Principale.SetActive (true);
		}
	}

	public void SetFirtsStart(bool firstStart){
		m_FirstStart = firstStart;
		m_BlackFadeIn.SetActive (false);
	}

	public bool GetFirtsStart(){
		return m_FirstStart;
	}
}
