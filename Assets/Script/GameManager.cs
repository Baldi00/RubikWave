using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	protected StatoCubo m_StatoCubo;

	[SerializeField]
	protected int m_NumMosseInizializzazione = 10;
	protected int m_NumMosseEseguite = 0;
	protected Animatore m_Animatore;

	protected bool m_GameRunning;

	[SerializeField]
	protected GameObject m_MenuPrincipale;

	[SerializeField]
	protected GameObject m_MenuPrincipalePrincipaleContinua;

	[SerializeField]
	protected GameObject m_Congratulazioni;
	[SerializeField]
	protected AudioSource m_SuonoVittoria;
	protected bool m_hoGiaVintoUnaVolta = false;

	[SerializeField]
	protected int m_VelocitaMescola = 5;

	[SerializeField]
	protected StatisticheInGame m_StatisticheInGame;

	protected bool m_CheckVittoria = false;


	void Start () {
		m_StatoCubo = GetComponent<StatoCubo> ();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		m_GameRunning = false;

		if (FileManager.isGameSavePresent () && FileManager.caricaDaFile ()) {
			Color attivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFFFF", out attivato);
			m_MenuPrincipalePrincipaleContinua.GetComponent<Text> ().color = attivato;
			m_MenuPrincipalePrincipaleContinua.GetComponent<BoxCollider> ().enabled = true;
		} else {
			Color disattivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFF64", out disattivato);
			m_MenuPrincipalePrincipaleContinua.GetComponent<Text>().color = disattivato;
			m_MenuPrincipalePrincipaleContinua.GetComponent<BoxCollider> ().enabled = false;

			GetComponent<SettingsManager> ().SetAlto ();
			GetComponent<SettingsManager> ().SetSuoniOn ();
		}

		if (ThroughScenesParameters.getSceneToLoad() == 0) {
			Color attivato = new Color ();
			ColorUtility.TryParseHtmlString ("#00CAFFFF", out attivato);
			m_MenuPrincipalePrincipaleContinua.GetComponent<Text> ().color = attivato;
			m_MenuPrincipalePrincipaleContinua.GetComponent<BoxCollider> ().enabled = true;

			ResetCubo ();
			ResetMosseEseguite ();
			ResetTimer ();

			m_MenuPrincipale.GetComponent<MenuPrincipale>().SetFirtsStart(false);
			m_MenuPrincipale.SetActive (false);
			m_GameRunning = true;
		}
	}


	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Escape) && m_GameRunning) {
			m_MenuPrincipale.SetActive (true);
			m_GameRunning = false;
		}

		if (m_CheckVittoria && m_Animatore.isFermo () && m_GameRunning) {
			if (HoVinto ()) {
				if (!m_hoGiaVintoUnaVolta) {
					m_Congratulazioni.SetActive (true);
					m_SuonoVittoria.enabled = false;
					m_SuonoVittoria.enabled = true;
					m_hoGiaVintoUnaVolta = true;
				}
			} else {
				m_Congratulazioni.SetActive (false);
				m_hoGiaVintoUnaVolta = false;
			}

			m_CheckVittoria = false;
		}
	}

	public void ToggleGameRunning(){
		m_GameRunning = !m_GameRunning;
	}

	public bool IsGameRunning(){
		return m_GameRunning;
	}

	public void HoFattoUnaMossa(){
		m_NumMosseEseguite++;
	}

	public void HoFattoPiuMosse(int numMosseEseguite){
		m_NumMosseEseguite+=numMosseEseguite;
	}

	public int GetNumMosseEseguite(){
		return m_NumMosseEseguite;
	}

	public void SetNumMosseEseguite(int newMosseEseguite){
		m_NumMosseEseguite = newMosseEseguite;
	}

	public int GetTimerOre(){
		return m_StatisticheInGame.GetOre();
	}

	public int GetTimerMinuti(){
		return m_StatisticheInGame.GetMinuti();
	}

	public float GetTimerSecondi(){
		return m_StatisticheInGame.GetSecondi();
	}

	public void SetTimerOre(int newOre){
		m_StatisticheInGame.SetOre(newOre);
	}

	public void SetTimerMinuti(int newMinuti){
		m_StatisticheInGame.SetMinuti(newMinuti);
	}

	public void SetTimerSecondi(float newSecondi){
		m_StatisticheInGame.SetSecondi(newSecondi);
	}

	public void ResetMosseEseguite(){
		m_NumMosseEseguite = 0;
	}

	public void ResetTimer(){
		m_StatisticheInGame.TimeReset ();
	}

	public void ResetCubo(){
		m_StatoCubo.ResetCubo ();
	}

	public bool HoVinto(){
		if (m_NumMosseEseguite <= 0)
			return false;
		return m_StatoCubo.IsStatoIniziale();
	}

	public void ControllaSeHoVinto(){
		m_CheckVittoria = true;
	}

	public int GetNumMosseInizializzazione(){
		return m_NumMosseInizializzazione;
	}

	public int GetVelocitaMescola(){
		return m_VelocitaMescola;
	}

	public bool ColorCompare(Color c1, Color c2){
		bool r = (int)(c1.r * 1000) == (int)(c2.r * 1000);
		bool g = (int)(c1.g * 1000) == (int)(c2.g * 1000);
		bool b = (int)(c1.b * 1000) == (int)(c2.b * 1000);
		bool a = (int)(c1.a * 1000) == (int)(c2.a * 1000);

		return r & b & g & a;
	}
}
