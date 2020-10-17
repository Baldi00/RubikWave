using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISprite : MonoBehaviour {
	private SpriteRenderer m_Sprite = null;
	private MovimentatoreCamera m_Camera = null;
	private StatoCubo m_StatoCubo = null;
	private Animatore m_Animatore = null;
	private AudioSource m_SuonoRotazione;
	private GameManager m_GameManager;

	[SerializeField]
	private int m_Action = 0;

	// Use this for initialization
	void Start () {
		m_Sprite = gameObject.GetComponent<SpriteRenderer> ();
		m_Camera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();
		m_StatoCubo = GameObject.Find ("GameManager").GetComponent<StatoCubo>();
		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		m_SuonoRotazione = GameObject.Find ("Cubo").GetComponent<AudioSource> ();
		m_GameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!m_Camera.isFermo () || !m_Animatore.isFermo ())
			m_Sprite.enabled = false;
	}

	void OnMouseEnter(){
		if (m_Camera.isFermo () && m_Animatore.isFermo ())
			m_Sprite.enabled = true;
	}

	void OnMouseOver(){
		if (m_Camera.isFermo () && m_Animatore.isFermo () && m_GameManager.IsGameRunning()) {
			m_Sprite.enabled = true;
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				switch (m_Action) {
				case 1:
					m_StatoCubo.FrontOrario ();
					break;
				case 2:
					m_StatoCubo.FrontAntioriario ();
					break;
				case 3:
					m_StatoCubo.BackOrario ();
					break;
				case 4:
					m_StatoCubo.BackAntioriario ();
					break;
				case 5:
					m_StatoCubo.LeftOrario ();
					break;
				case 6:
					m_StatoCubo.LeftAntioriario ();
					break;
				case 7:
					m_StatoCubo.RightOrario ();
					break;
				case 8:
					m_StatoCubo.RightAntioriario ();
					break;
				case 9:
					m_StatoCubo.UpOrario ();
					break;
				case 10:
					m_StatoCubo.UpAntioriario ();
					break;
				case 11:
					m_StatoCubo.DownOrario ();
					break;
				case 12:
					m_StatoCubo.DownAntioriario ();
					break;
				}
				m_SuonoRotazione.enabled = false;
				m_SuonoRotazione.enabled = true;
				m_GameManager.HoFattoUnaMossa ();
				m_GameManager.ControllaSeHoVinto ();
			}
		} else {
			m_Sprite.enabled = false;
		}
	}

	void OnMouseExit(){
		m_Sprite.enabled = false;
	}
}
