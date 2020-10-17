using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour {

	private int m_Pos;
	private MovimentatoreCamera m_Movimentatore = null;
	private AudioSource m_SuonoCamera;
	private GameManager m_GameManager;

	private bool m_Invertito;

	// Use this for initialization
	void Start () {
		m_Pos = 1;
		m_Invertito = true;
		m_Movimentatore = GetComponent<MovimentatoreCamera> ();
		m_SuonoCamera = GetComponent<AudioSource> ();
		m_GameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		bool checkSinistra = Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow);
		bool checkDestra = Input.GetKeyDown (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow);
		bool checkSu = Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow);
		bool checkGiu = Input.GetKeyDown (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow);

		if (m_Movimentatore.isFermo () && m_GameManager.IsGameRunning()) {
			if (!m_Invertito) {
				if (checkSinistra) {
					switch (m_Pos) {
					case 1:
						m_Pos = 4;
						break;
					case 5:
						m_Pos = 8;
						break;
					default:
						m_Pos = m_Pos - 1;
						break;
					}
					m_SuonoCamera.enabled = false;
					m_SuonoCamera.enabled = true;
				}

				if (checkDestra) {
					switch (m_Pos) {
					case 4:
						m_Pos = 1;
						break;
					case 8:
						m_Pos = 5;
						break;
					default:
						m_Pos = m_Pos + 1;
						break;
					}
					m_SuonoCamera.enabled = false;
					m_SuonoCamera.enabled = true;
				}

				if (checkSu) {
					if (m_Pos < 5) {
						m_Pos += 4;
						m_SuonoCamera.enabled = false;
						m_SuonoCamera.enabled = true;
					}
				}
				if (checkGiu) {
					if (m_Pos > 4) {
						m_Pos -= 4;
						m_SuonoCamera.enabled = false;
						m_SuonoCamera.enabled = true;
					}
				}
			} else {
				if (checkDestra) {
					switch (m_Pos) {
					case 1:
						m_Pos = 4;
						break;
					case 5:
						m_Pos = 8;
						break;
					default:
						m_Pos = m_Pos - 1;
						break;
					}
					m_SuonoCamera.enabled = false;
					m_SuonoCamera.enabled = true;
				}

				if (checkSinistra) {
					switch (m_Pos) {
					case 4:
						m_Pos = 1;
						break;
					case 8:
						m_Pos = 5;
						break;
					default:
						m_Pos = m_Pos + 1;
						break;
					}

					m_SuonoCamera.enabled = false;
					m_SuonoCamera.enabled = true;
				}

				if (checkGiu) {
					if (m_Pos < 5) {
						m_Pos += 4;
						m_SuonoCamera.enabled = false;
						m_SuonoCamera.enabled = true;
					}
				}
				if (checkSu) {
					if (m_Pos > 4) {
						m_Pos -= 4;
						m_SuonoCamera.enabled = false;
						m_SuonoCamera.enabled = true;
					}
				}
			}

			if (Input.GetKeyDown (KeyCode.R)) {
				m_Movimentatore.ruota();
				m_Invertito = !m_Invertito;
				m_SuonoCamera.enabled = false;
				m_SuonoCamera.enabled = true;
			}
		}
	}

	public int GetPosizione (){
		return m_Pos;
	}
}
