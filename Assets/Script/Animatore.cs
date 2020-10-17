using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animatore : MonoBehaviour {

	[SerializeField]
	private int m_Frames = 30;
	private int m_Steps;
	private bool m_Orario = true;
	private int m_DaRoutare = 0;

	[SerializeField]
	private GameObject m_FrontAnim, m_BackAnim, m_LeftAnim, m_RightAnim, m_UpAnim, m_DownAnim;

	private StatoCubo m_StatoCubo;

	private GameObject VertFrontLeftUpFrontAnim,VertFrontRightUpFrontAnim,VertFrontLeftDownFrontAnim,VertFrontRightDownFrontAnim,VertLeftRightUpFrontAnim,VertLeftRightDownFrontAnim,VertRightLeftUpFrontAnim,VertRightLeftDownFrontAnim,VertUpLeftDownFrontAnim,VertUpRightDownFrontAnim,VertDownLeftUpFrontAnim,VertDownRightUpFrontAnim;
	private GameObject VertFrontLeftUpBackAnim,VertFrontRightUpBackAnim,VertFrontLeftDownBackAnim,VertFrontRightDownBackAnim,VertLeftRightUpBackAnim,VertLeftRightDownBackAnim,VertRightLeftUpBackAnim,VertRightLeftDownBackAnim,VertUpLeftDownBackAnim,VertUpRightDownBackAnim,VertDownLeftUpBackAnim,VertDownRightUpBackAnim;
	private GameObject VertFrontLeftUpLeftAnim,VertFrontRightUpLeftAnim,VertFrontLeftDownLeftAnim,VertFrontRightDownLeftAnim,VertLeftRightUpLeftAnim,VertLeftRightDownLeftAnim,VertRightLeftUpLeftAnim,VertRightLeftDownLeftAnim,VertUpLeftDownLeftAnim,VertUpRightDownLeftAnim,VertDownLeftUpLeftAnim,VertDownRightUpLeftAnim;
	private GameObject VertFrontLeftUpRightAnim,VertFrontRightUpRightAnim,VertFrontLeftDownRightAnim,VertFrontRightDownRightAnim,VertLeftRightUpRightAnim,VertLeftRightDownRightAnim,VertRightLeftUpRightAnim,VertRightLeftDownRightAnim,VertUpLeftDownRightAnim,VertUpRightDownRightAnim,VertDownLeftUpRightAnim,VertDownRightUpRightAnim;
	private GameObject VertFrontLeftUpUpAnim,VertFrontRightUpUpAnim,VertFrontLeftDownUpAnim,VertFrontRightDownUpAnim,VertLeftRightUpUpAnim,VertLeftRightDownUpAnim,VertRightLeftUpUpAnim,VertRightLeftDownUpAnim,VertUpLeftDownUpAnim,VertUpRightDownUpAnim,VertDownLeftUpUpAnim,VertDownRightUpUpAnim;
	private GameObject VertFrontLeftUpDownAnim,VertFrontRightUpDownAnim,VertFrontLeftDownDownAnim,VertFrontRightDownDownAnim,VertLeftRightUpDownAnim,VertLeftRightDownDownAnim,VertRightLeftUpDownAnim,VertRightLeftDownDownAnim,VertUpLeftDownDownAnim,VertUpRightDownDownAnim,VertDownLeftUpDownAnim,VertDownRightUpDownAnim;

	private GameObject SpigFrontUpFrontAnim,SpigFrontDownFrontAnim,SpigFrontLeftFrontAnim,SpigFrontRightFrontAnim,SpigLeftRightFrontAnim,SpigRightLeftFrontAnim,SpigUpDownFrontAnim,SpigDownUpFrontAnim;
	private GameObject SpigFrontUpBackAnim,SpigFrontDownBackAnim,SpigFrontLeftBackAnim,SpigFrontRightBackAnim,SpigLeftRightBackAnim,SpigRightLeftBackAnim,SpigUpDownBackAnim,SpigDownUpBackAnim;
	private GameObject SpigFrontUpLeftAnim,SpigFrontDownLeftAnim,SpigFrontLeftLeftAnim,SpigFrontRightLeftAnim,SpigLeftRightLeftAnim,SpigRightLeftLeftAnim,SpigUpDownLeftAnim,SpigDownUpLeftAnim;
	private GameObject SpigFrontUpRightAnim,SpigFrontDownRightAnim,SpigFrontLeftRightAnim,SpigFrontRightRightAnim,SpigLeftRightRightAnim,SpigRightLeftRightAnim,SpigUpDownRightAnim,SpigDownUpRightAnim;
	private GameObject SpigFrontUpUpAnim,SpigFrontDownUpAnim,SpigFrontLeftUpAnim,SpigFrontRightUpAnim,SpigLeftRightUpAnim,SpigRightLeftUpAnim,SpigUpDownUpAnim,SpigDownUpUpAnim;
	private GameObject SpigFrontUpDownAnim,SpigFrontDownDownAnim,SpigFrontLeftDownAnim,SpigFrontRightDownAnim,SpigLeftRightDownAnim,SpigRightLeftDownAnim,SpigUpDownDownAnim,SpigDownUpDownAnim;

	private AudioSource m_SuonoRotazione;

	//Mescola
	private int m_Index;
	private int [] m_Mosse;
	private int m_NumMosse;
	private bool m_Continua = false;
	private bool m_StoMescolando = false;
	private bool m_StoRisolvendo = false;

	void Start () {
		m_Steps = 0;

		VertFrontLeftUpFrontAnim = GameObject.Find("VertFrontLeftUpFrontAnim");
		VertFrontRightUpFrontAnim = GameObject.Find("VertFrontRightUpFrontAnim");
		VertFrontLeftDownFrontAnim = GameObject.Find("VertFrontLeftDownFrontAnim");
		VertFrontRightDownFrontAnim = GameObject.Find("VertFrontRightDownFrontAnim");
		VertLeftRightUpFrontAnim = GameObject.Find("VertLeftRightUpFrontAnim");
		VertLeftRightDownFrontAnim = GameObject.Find("VertLeftRightDownFrontAnim");
		VertRightLeftUpFrontAnim = GameObject.Find("VertRightLeftUpFrontAnim");
		VertRightLeftDownFrontAnim = GameObject.Find("VertRightLeftDownFrontAnim");
		VertUpLeftDownFrontAnim = GameObject.Find("VertUpLeftDownFrontAnim");
		VertUpRightDownFrontAnim = GameObject.Find("VertUpRightDownFrontAnim");
		VertDownLeftUpFrontAnim = GameObject.Find("VertDownLeftUpFrontAnim");
		VertDownRightUpFrontAnim = GameObject.Find("VertDownRightUpFrontAnim");
		VertFrontLeftUpBackAnim = GameObject.Find("VertFrontLeftUpBackAnim");
		VertFrontRightUpBackAnim = GameObject.Find("VertFrontRightUpBackAnim");
		VertFrontLeftDownBackAnim = GameObject.Find("VertFrontLeftDownBackAnim");
		VertFrontRightDownBackAnim = GameObject.Find("VertFrontRightDownBackAnim");
		VertLeftRightUpBackAnim = GameObject.Find("VertLeftRightUpBackAnim");
		VertLeftRightDownBackAnim = GameObject.Find("VertLeftRightDownBackAnim");
		VertRightLeftUpBackAnim = GameObject.Find("VertRightLeftUpBackAnim");
		VertRightLeftDownBackAnim = GameObject.Find("VertRightLeftDownBackAnim");
		VertUpLeftDownBackAnim = GameObject.Find("VertUpLeftDownBackAnim");
		VertUpRightDownBackAnim = GameObject.Find("VertUpRightDownBackAnim");
		VertDownLeftUpBackAnim = GameObject.Find("VertDownLeftUpBackAnim");
		VertDownRightUpBackAnim = GameObject.Find("VertDownRightUpBackAnim");
		VertFrontLeftUpLeftAnim = GameObject.Find("VertFrontLeftUpLeftAnim");
		VertFrontRightUpLeftAnim = GameObject.Find("VertFrontRightUpLeftAnim");
		VertFrontLeftDownLeftAnim = GameObject.Find("VertFrontLeftDownLeftAnim");
		VertFrontRightDownLeftAnim = GameObject.Find("VertFrontRightDownLeftAnim");
		VertLeftRightUpLeftAnim = GameObject.Find("VertLeftRightUpLeftAnim");
		VertLeftRightDownLeftAnim = GameObject.Find("VertLeftRightDownLeftAnim");
		VertRightLeftUpLeftAnim = GameObject.Find("VertRightLeftUpLeftAnim");
		VertRightLeftDownLeftAnim = GameObject.Find("VertRightLeftDownLeftAnim");
		VertUpLeftDownLeftAnim = GameObject.Find("VertUpLeftDownLeftAnim");
		VertUpRightDownLeftAnim = GameObject.Find("VertUpRightDownLeftAnim");
		VertDownLeftUpLeftAnim = GameObject.Find("VertDownLeftUpLeftAnim");
		VertDownRightUpLeftAnim = GameObject.Find("VertDownRightUpLeftAnim");
		VertFrontLeftUpRightAnim = GameObject.Find("VertFrontLeftUpRightAnim");
		VertFrontRightUpRightAnim = GameObject.Find("VertFrontRightUpRightAnim");
		VertFrontLeftDownRightAnim = GameObject.Find("VertFrontLeftDownRightAnim");
		VertFrontRightDownRightAnim = GameObject.Find("VertFrontRightDownRightAnim");
		VertLeftRightUpRightAnim = GameObject.Find("VertLeftRightUpRightAnim");
		VertLeftRightDownRightAnim = GameObject.Find("VertLeftRightDownRightAnim");
		VertRightLeftUpRightAnim = GameObject.Find("VertRightLeftUpRightAnim");
		VertRightLeftDownRightAnim = GameObject.Find("VertRightLeftDownRightAnim");
		VertUpLeftDownRightAnim = GameObject.Find("VertUpLeftDownRightAnim");
		VertUpRightDownRightAnim = GameObject.Find("VertUpRightDownRightAnim");
		VertDownLeftUpRightAnim = GameObject.Find("VertDownLeftUpRightAnim");
		VertDownRightUpRightAnim = GameObject.Find("VertDownRightUpRightAnim");
		VertFrontLeftUpUpAnim = GameObject.Find("VertFrontLeftUpUpAnim");
		VertFrontRightUpUpAnim = GameObject.Find("VertFrontRightUpUpAnim");
		VertFrontLeftDownUpAnim = GameObject.Find("VertFrontLeftDownUpAnim");
		VertFrontRightDownUpAnim = GameObject.Find("VertFrontRightDownUpAnim");
		VertLeftRightUpUpAnim = GameObject.Find("VertLeftRightUpUpAnim");
		VertLeftRightDownUpAnim = GameObject.Find("VertLeftRightDownUpAnim");
		VertRightLeftUpUpAnim = GameObject.Find("VertRightLeftUpUpAnim");
		VertRightLeftDownUpAnim = GameObject.Find("VertRightLeftDownUpAnim");
		VertUpLeftDownUpAnim = GameObject.Find("VertUpLeftDownUpAnim");
		VertUpRightDownUpAnim = GameObject.Find("VertUpRightDownUpAnim");
		VertDownLeftUpUpAnim = GameObject.Find("VertDownLeftUpUpAnim");
		VertDownRightUpUpAnim = GameObject.Find("VertDownRightUpUpAnim");
		VertFrontLeftUpDownAnim = GameObject.Find("VertFrontLeftUpDownAnim");
		VertFrontRightUpDownAnim = GameObject.Find("VertFrontRightUpDownAnim");
		VertFrontLeftDownDownAnim = GameObject.Find("VertFrontLeftDownDownAnim");
		VertFrontRightDownDownAnim = GameObject.Find("VertFrontRightDownDownAnim");
		VertLeftRightUpDownAnim = GameObject.Find("VertLeftRightUpDownAnim");
		VertLeftRightDownDownAnim = GameObject.Find("VertLeftRightDownDownAnim");
		VertRightLeftUpDownAnim = GameObject.Find("VertRightLeftUpDownAnim");
		VertRightLeftDownDownAnim = GameObject.Find("VertRightLeftDownDownAnim");
		VertUpLeftDownDownAnim = GameObject.Find("VertUpLeftDownDownAnim");
		VertUpRightDownDownAnim = GameObject.Find("VertUpRightDownDownAnim");
		VertDownLeftUpDownAnim = GameObject.Find("VertDownLeftUpDownAnim");
		VertDownRightUpDownAnim = GameObject.Find("VertDownRightUpDownAnim");

		SpigFrontUpFrontAnim = GameObject.Find("SpigFrontUpFrontAnim");
		SpigFrontDownFrontAnim = GameObject.Find("SpigFrontDownFrontAnim");
		SpigFrontLeftFrontAnim = GameObject.Find("SpigFrontLeftFrontAnim");
		SpigFrontRightFrontAnim = GameObject.Find("SpigFrontRightFrontAnim");
		SpigLeftRightFrontAnim = GameObject.Find("SpigLeftRightFrontAnim");
		SpigRightLeftFrontAnim = GameObject.Find("SpigRightLeftFrontAnim");
		SpigUpDownFrontAnim = GameObject.Find("SpigUpDownFrontAnim");
		SpigDownUpFrontAnim = GameObject.Find("SpigDownUpFrontAnim");
		SpigFrontUpBackAnim = GameObject.Find("SpigFrontUpBackAnim");
		SpigFrontDownBackAnim = GameObject.Find("SpigFrontDownBackAnim");
		SpigFrontLeftBackAnim = GameObject.Find("SpigFrontLeftBackAnim");
		SpigFrontRightBackAnim = GameObject.Find("SpigFrontRightBackAnim");
		SpigLeftRightBackAnim = GameObject.Find("SpigLeftRightBackAnim");
		SpigRightLeftBackAnim = GameObject.Find("SpigRightLeftBackAnim");
		SpigUpDownBackAnim = GameObject.Find("SpigUpDownBackAnim");
		SpigDownUpBackAnim = GameObject.Find("SpigDownUpBackAnim");
		SpigFrontUpLeftAnim = GameObject.Find("SpigFrontUpLeftAnim");
		SpigFrontDownLeftAnim = GameObject.Find("SpigFrontDownLeftAnim");
		SpigFrontLeftLeftAnim = GameObject.Find("SpigFrontLeftLeftAnim");
		SpigFrontRightLeftAnim = GameObject.Find("SpigFrontRightLeftAnim");
		SpigLeftRightLeftAnim = GameObject.Find("SpigLeftRightLeftAnim");
		SpigRightLeftLeftAnim = GameObject.Find("SpigRightLeftLeftAnim");
		SpigUpDownLeftAnim = GameObject.Find("SpigUpDownLeftAnim");
		SpigDownUpLeftAnim = GameObject.Find("SpigDownUpLeftAnim");
		SpigFrontUpRightAnim = GameObject.Find("SpigFrontUpRightAnim");
		SpigFrontDownRightAnim = GameObject.Find("SpigFrontDownRightAnim");
		SpigFrontLeftRightAnim = GameObject.Find("SpigFrontLeftRightAnim");
		SpigFrontRightRightAnim = GameObject.Find("SpigFrontRightRightAnim");
		SpigLeftRightRightAnim = GameObject.Find("SpigLeftRightRightAnim");
		SpigRightLeftRightAnim = GameObject.Find("SpigRightLeftRightAnim");
		SpigUpDownRightAnim = GameObject.Find("SpigUpDownRightAnim");
		SpigDownUpRightAnim = GameObject.Find("SpigDownUpRightAnim");
		SpigFrontUpUpAnim = GameObject.Find("SpigFrontUpUpAnim");
		SpigFrontDownUpAnim = GameObject.Find("SpigFrontDownUpAnim");
		SpigFrontLeftUpAnim = GameObject.Find("SpigFrontLeftUpAnim");
		SpigFrontRightUpAnim = GameObject.Find("SpigFrontRightUpAnim");
		SpigLeftRightUpAnim = GameObject.Find("SpigLeftRightUpAnim");
		SpigRightLeftUpAnim = GameObject.Find("SpigRightLeftUpAnim");
		SpigUpDownUpAnim = GameObject.Find("SpigUpDownUpAnim");
		SpigDownUpUpAnim = GameObject.Find("SpigDownUpUpAnim");
		SpigFrontUpDownAnim = GameObject.Find("SpigFrontUpDownAnim");
		SpigFrontDownDownAnim = GameObject.Find("SpigFrontDownDownAnim");
		SpigFrontLeftDownAnim = GameObject.Find("SpigFrontLeftDownAnim");
		SpigFrontRightDownAnim = GameObject.Find("SpigFrontRightDownAnim");
		SpigLeftRightDownAnim = GameObject.Find("SpigLeftRightDownAnim");
		SpigRightLeftDownAnim = GameObject.Find("SpigRightLeftDownAnim");
		SpigUpDownDownAnim = GameObject.Find("SpigUpDownDownAnim");
		SpigDownUpDownAnim = GameObject.Find("SpigDownUpDownAnim");

		m_FrontAnim.SetActive (false);
		m_BackAnim.SetActive (false);
		m_LeftAnim.SetActive (false);
		m_RightAnim.SetActive (false);
		m_UpAnim.SetActive (false);
		m_DownAnim.SetActive (false);

		m_StatoCubo = GameObject.Find ("GameManager").GetComponent<StatoCubo> ();
		m_SuonoRotazione = GameObject.Find ("Cubo").GetComponent<AudioSource> ();
	}

	void FixedUpdate () {
		if (m_Steps > 0) {

			Quaternion rotation = Quaternion.identity;
			float gradi;

			if (m_Orario)
				gradi = 90f;
			else
				gradi = -90f;

			switch(m_DaRoutare){
			case 1:
				rotation.eulerAngles = new Vector3 (m_FrontAnim.transform.rotation.eulerAngles.x, m_FrontAnim.transform.rotation.eulerAngles.y, m_FrontAnim.transform.rotation.eulerAngles.z+gradi/m_Frames);
				m_FrontAnim.transform.rotation = rotation;
				break;

			case 2:
				rotation.eulerAngles = new Vector3 (m_BackAnim.transform.rotation.eulerAngles.x, m_BackAnim.transform.rotation.eulerAngles.y, m_BackAnim.transform.rotation.eulerAngles.z+gradi/m_Frames);
				m_BackAnim.transform.rotation = rotation;
				break;

			case 3:
				rotation.eulerAngles = new Vector3 (m_LeftAnim.transform.rotation.eulerAngles.x, m_LeftAnim.transform.rotation.eulerAngles.y, m_LeftAnim.transform.rotation.eulerAngles.z+gradi/m_Frames);
				m_LeftAnim.transform.rotation = rotation;
				break;

			case 4:
				rotation.eulerAngles = new Vector3 (m_RightAnim.transform.rotation.eulerAngles.x, m_RightAnim.transform.rotation.eulerAngles.y, m_RightAnim.transform.rotation.eulerAngles.z+gradi/m_Frames);
				m_RightAnim.transform.rotation = rotation;
				break;

			case 5:
				rotation.eulerAngles = new Vector3 (m_UpAnim.transform.rotation.eulerAngles.x, m_UpAnim.transform.rotation.eulerAngles.y, m_UpAnim.transform.rotation.eulerAngles.z+gradi/m_Frames);
				m_UpAnim.transform.rotation = rotation;
				break;

			case 6:
				rotation.eulerAngles = new Vector3 (m_DownAnim.transform.rotation.eulerAngles.x, m_DownAnim.transform.rotation.eulerAngles.y, m_DownAnim.transform.rotation.eulerAngles.z+gradi/m_Frames);
				m_DownAnim.transform.rotation = rotation;
				break;
			}

			m_Steps -= 1;
				

			if (m_Steps == 0) {
				m_FrontAnim.SetActive (false);
				m_BackAnim.SetActive (false);
				m_LeftAnim.SetActive (false);
				m_RightAnim.SetActive (false);
				m_UpAnim.SetActive (false);
				m_DownAnim.SetActive (false);

				m_StatoCubo.AccendiTuttiCubetti ();

				switch(m_DaRoutare){
				case 1:
					rotation.eulerAngles = new Vector3 (m_FrontAnim.transform.rotation.eulerAngles.x, m_FrontAnim.transform.rotation.eulerAngles.y, m_FrontAnim.transform.rotation.eulerAngles.z-gradi);
					m_FrontAnim.transform.rotation = rotation;
					break;

				case 2:
					rotation.eulerAngles = new Vector3 (m_BackAnim.transform.rotation.eulerAngles.x, m_BackAnim.transform.rotation.eulerAngles.y, m_BackAnim.transform.rotation.eulerAngles.z-gradi);
					m_BackAnim.transform.rotation = rotation;
					break;

				case 3:
					rotation.eulerAngles = new Vector3 (m_LeftAnim.transform.rotation.eulerAngles.x, m_LeftAnim.transform.rotation.eulerAngles.y, m_LeftAnim.transform.rotation.eulerAngles.z-gradi);
					m_LeftAnim.transform.rotation = rotation;
					break;

				case 4:
					rotation.eulerAngles = new Vector3 (m_RightAnim.transform.rotation.eulerAngles.x, m_RightAnim.transform.rotation.eulerAngles.y, m_RightAnim.transform.rotation.eulerAngles.z-gradi);
					m_RightAnim.transform.rotation = rotation;
					break;

				case 5:
					rotation.eulerAngles = new Vector3 (m_UpAnim.transform.rotation.eulerAngles.x, m_UpAnim.transform.rotation.eulerAngles.y, m_UpAnim.transform.rotation.eulerAngles.z-gradi);
					m_UpAnim.transform.rotation = rotation;
					break;

				case 6:
					rotation.eulerAngles = new Vector3 (m_DownAnim.transform.rotation.eulerAngles.x, m_DownAnim.transform.rotation.eulerAngles.y, m_DownAnim.transform.rotation.eulerAngles.z-gradi);
					m_DownAnim.transform.rotation = rotation;
					break;
				}

				if (m_Continua) {
					m_Index++;
					if (m_Index == m_NumMosse) {
						m_Continua = false;
						if (m_StoMescolando) {
							m_StoMescolando = false;
						}
						m_Frames = 15;
					}
					else {
						switch (m_Mosse[m_Index]) {
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
					}
				}
			}
				
		}
	}

	public void Front(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		m_Steps = m_Frames;
		m_FrontAnim.SetActive (true);

		VertFrontLeftUpFrontAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpFrontAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownFrontAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownFrontAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpFrontAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownFrontAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpFrontAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownFrontAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownFrontAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownFrontAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpFrontAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpFrontAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpFrontAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownFrontAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftFrontAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightFrontAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightFrontAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftFrontAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownFrontAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpFrontAnim.GetComponent<Renderer>().material.color = c20;

		m_Orario = orario;

		m_DaRoutare = 1;
	}

	public void Back(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		m_Steps = m_Frames;
		m_BackAnim.SetActive(true);

		VertFrontLeftUpBackAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpBackAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownBackAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownBackAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpBackAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownBackAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpBackAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownBackAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownBackAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownBackAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpBackAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpBackAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpBackAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownBackAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftBackAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightBackAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightBackAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftBackAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownBackAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpBackAnim.GetComponent<Renderer>().material.color = c20;

		m_Orario = orario;

		m_DaRoutare = 2;
	}

	public void Left(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		m_Steps = m_Frames;
		m_LeftAnim.SetActive (true);

		VertFrontLeftUpLeftAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpLeftAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownLeftAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownLeftAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpLeftAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownLeftAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpLeftAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownLeftAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownLeftAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownLeftAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpLeftAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpLeftAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpLeftAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownLeftAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftLeftAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightLeftAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightLeftAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftLeftAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownLeftAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpLeftAnim.GetComponent<Renderer>().material.color = c20;

		m_Orario = orario;

		m_DaRoutare = 3;
	}

	public void Right(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		m_Steps = m_Frames;
		m_RightAnim.SetActive (true);

		VertFrontLeftUpRightAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpRightAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownRightAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownRightAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpRightAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownRightAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpRightAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownRightAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownRightAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownRightAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpRightAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpRightAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpRightAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownRightAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftRightAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightRightAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightRightAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftRightAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownRightAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpRightAnim.GetComponent<Renderer>().material.color = c20;

		m_Orario = orario;

		m_DaRoutare = 4;
	}

	public void Up(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		m_Steps = m_Frames;
		m_UpAnim.SetActive (true);

		VertFrontLeftUpUpAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpUpAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownUpAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownUpAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpUpAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownUpAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpUpAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownUpAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownUpAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownUpAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpUpAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpUpAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpUpAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownUpAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftUpAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightUpAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightUpAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftUpAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownUpAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpUpAnim.GetComponent<Renderer>().material.color = c20;

		m_Orario = orario;

		m_DaRoutare = 5;
	}

	public void Down(Color c1,Color c2,Color c3,Color c4,Color c5,Color c6,Color c7,Color c8,Color c9,Color c10,Color c11,Color c12,Color c13,Color c14,Color c15,Color c16,Color c17,Color c18,Color c19,Color c20,bool orario){
		m_Steps = m_Frames;
		m_DownAnim.SetActive (true);

		VertFrontLeftUpDownAnim.GetComponent<Renderer>().material.color = c1;
		VertFrontRightUpDownAnim.GetComponent<Renderer>().material.color = c2;
		VertFrontLeftDownDownAnim.GetComponent<Renderer>().material.color = c3;
		VertFrontRightDownDownAnim.GetComponent<Renderer>().material.color = c4;
		VertLeftRightUpDownAnim.GetComponent<Renderer>().material.color = c5;
		VertLeftRightDownDownAnim.GetComponent<Renderer>().material.color = c6;
		VertRightLeftUpDownAnim.GetComponent<Renderer>().material.color = c7;
		VertRightLeftDownDownAnim.GetComponent<Renderer>().material.color = c8;
		VertUpLeftDownDownAnim.GetComponent<Renderer>().material.color = c9;
		VertUpRightDownDownAnim.GetComponent<Renderer>().material.color = c10;
		VertDownLeftUpDownAnim.GetComponent<Renderer>().material.color = c11;
		VertDownRightUpDownAnim.GetComponent<Renderer>().material.color = c12;
		SpigFrontUpDownAnim.GetComponent<Renderer>().material.color = c13;
		SpigFrontDownDownAnim.GetComponent<Renderer>().material.color = c14;
		SpigFrontLeftDownAnim.GetComponent<Renderer>().material.color = c15;
		SpigFrontRightDownAnim.GetComponent<Renderer>().material.color = c16;
		SpigLeftRightDownAnim.GetComponent<Renderer>().material.color = c17;
		SpigRightLeftDownAnim.GetComponent<Renderer>().material.color = c18;
		SpigUpDownDownAnim.GetComponent<Renderer>().material.color = c19;
		SpigDownUpDownAnim.GetComponent<Renderer>().material.color = c20;

		m_Orario = orario;

		m_DaRoutare = 6;
	}

	public bool isFermo(){
		if (m_Steps == 0) {
			return !m_StoMescolando && !m_StoRisolvendo;
		}

		return false;
	}

	public bool isFermoAnimatorePuoAndare(){
		return m_Steps == 0 && !m_StoMescolando && m_StoRisolvendo;
	}

	public void SetFrames(int frames){
		m_Frames = frames;
	}

	public void EseguiPiuMosse(int[] mosse, int velocita){
		m_Mosse = mosse;
		m_Index = 0;
		m_NumMosse = m_Mosse.Length;
		m_Continua = true;
		m_Frames = velocita;
		switch (m_Mosse[m_Index]) {
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
	}

	public bool StoMescolando(){
		return m_StoMescolando;
	}

	public void SetStatoStoMescolando(bool stoMescolando){
		m_StoMescolando = stoMescolando;
	}

	public bool StoRisolvendo(){
		return m_StoRisolvendo;
	}

	public void SetStatoStoRisolvendo(bool stoRisolvendo){
		m_StoRisolvendo = stoRisolvendo;
	}
}
