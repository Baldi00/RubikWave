using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class SettingsManager : MonoBehaviour {

	[SerializeField]
	private GameObject m_CameraPrincipale;

	[SerializeField]
	private PostProcessingProfile m_Alto, m_Medio, m_Basso;

	[SerializeField]
	private GameObject m_Cubo;

	[SerializeField]
	private AudioClip m_Whoosh, m_Turn, m_Victory;

	[SerializeField]
	private ScrittaMenuOpzioni m_ScrittaAlto, m_ScrittaMedio, m_ScrittaBasso, m_ScrittaSuoniOn, m_ScrittaSuoniOff;

	public void SetAlto(){
		m_CameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile = m_Alto;
		m_ScrittaAlto.SetAcceso (true);
	}

	public void SetMedio(){
		m_CameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile = m_Medio;
		m_ScrittaMedio.SetAcceso (true);
	}

	public void SetBasso(){
		m_CameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile = m_Basso;
		m_ScrittaBasso.SetAcceso (true);
	}

	public void SetSuoniOn(){
		m_Cubo.GetComponent<AudioSource> ().clip = m_Turn;
		m_CameraPrincipale.GetComponent<AudioSource> ().clip = m_Whoosh;
		GetComponent<AudioSource> ().clip = m_Victory;
		m_ScrittaSuoniOn.SetAcceso (true);
	}

	public void SetSuoniOff(){
		m_Cubo.GetComponent<AudioSource> ().clip = null;
		m_CameraPrincipale.GetComponent<AudioSource> ().clip = null;
		GetComponent<AudioSource> ().clip = null;
		m_ScrittaSuoniOff.SetAcceso (true);
	}

	public int GetGrafica(){
		if (m_CameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile == m_Alto) {
			return 2;
		} else if (m_CameraPrincipale.GetComponent<PostProcessingBehaviour> ().profile == m_Medio) {
			return 1;
		} else {
			return 0;
		}
	}

	public int GetSuoni(){
		if (GetComponent<AudioSource> ().clip == null) {
			return 0;
		} else {
			return 1;
		}
	}

	public void SetGrafica(int grafica){
		switch (grafica) {
		case 0: SetBasso (); break;
		case 1: SetMedio (); break;
		case 2: SetAlto (); break;
		}
	}

	public void SetSuoni(int suoni){
		if (suoni == 1) {
			SetSuoniOn ();
		} else {
			SetSuoniOff ();
		}
	}
}
