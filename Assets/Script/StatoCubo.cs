using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatoCubo : MonoBehaviour {

	private GameObject CentFront,CentBack,CentRight,CentLeft,CentUp,CentDown;

	private GameObject SpigFrontUp,SpigFrontLeft,SpigFrontRight,SpigFrontDown,SpigBackUp,SpigBackLeft,SpigBackRight,SpigBackDown,
	SpigRightUp,SpigRightLeft,SpigRightRight,SpigRightDown,SpigLeftUp,SpigLeftLeft,SpigLeftRight,SpigLeftDown,
	SpigUpUp,SpigUpLeft,SpigUpRight,SpigUpDown,SpigDownUp,SpigDownLeft,SpigDownRight,SpigDownDown;

	private GameObject VertFrontRightUp,VertFrontRightDown,VertFrontLeftUp,VertFrontLeftDown,VertBackRightUp,VertBackRightDown,VertBackLeftUp,VertBackLeftDown,
	VertLeftRightUp,VertLeftRightDown,VertLeftLeftUp,VertLeftLeftDown,VertRightRightUp,VertRightRightDown,VertRightLeftUp,VertRightLeftDown,
	VertUpRightUp,VertUpRightDown,VertUpLeftUp,VertUpLeftDown,VertDownRightUp,VertDownRightDown,VertDownLeftUp,VertDownLeftDown;

	private GameObject Cent1,Cent2,Cent3,Cent4,Cent5,Cent6;
	private GameObject Spig1,Spig2,Spig3,Spig4,Spig5,Spig6,Spig7,Spig8,Spig9,Spig10,Spig11,Spig12;
	private GameObject Vert1,Vert2,Vert3,Vert4,Vert5,Vert6,Vert7,Vert8;

	private bool m_Orario = true;

	private Animatore m_Animatore;

	void Start(){
		
		CentFront = GameObject.Find ("CentFront");
		CentBack = GameObject.Find ("CentBack");
		CentRight = GameObject.Find ("CentRight");
		CentLeft = GameObject.Find ("CentLeft");
		CentUp = GameObject.Find ("CentUp");
		CentDown = GameObject.Find ("CentDown");

		SpigFrontUp = GameObject.Find ("SpigFrontUp");
		SpigFrontLeft = GameObject.Find ("SpigFrontLeft");
		SpigFrontRight = GameObject.Find ("SpigFrontRight");
		SpigFrontDown = GameObject.Find ("SpigFrontDown");
		SpigBackUp = GameObject.Find ("SpigBackUp");
		SpigBackLeft = GameObject.Find ("SpigBackLeft");
		SpigBackRight = GameObject.Find ("SpigBackRight");
		SpigBackDown = GameObject.Find ("SpigBackDown");
		SpigRightUp = GameObject.Find ("SpigRightUp");
		SpigRightLeft = GameObject.Find ("SpigRightLeft");
		SpigRightRight = GameObject.Find ("SpigRightRight");
		SpigRightDown = GameObject.Find ("SpigRightDown");
		SpigLeftUp = GameObject.Find ("SpigLeftUp");
		SpigLeftLeft = GameObject.Find ("SpigLeftLeft");
		SpigLeftRight = GameObject.Find ("SpigLeftRight");
		SpigLeftDown = GameObject.Find ("SpigLeftDown");
		SpigUpUp = GameObject.Find ("SpigUpUp");
		SpigUpLeft = GameObject.Find ("SpigUpLeft");
		SpigUpRight = GameObject.Find ("SpigUpRight");
		SpigUpDown = GameObject.Find ("SpigUpDown");
		SpigDownUp = GameObject.Find ("SpigDownUp");
		SpigDownLeft = GameObject.Find ("SpigDownLeft");
		SpigDownRight = GameObject.Find ("SpigDownRight");
		SpigDownDown = GameObject.Find ("SpigDownDown");

		VertFrontRightUp = GameObject.Find ("VertFrontRightUp");
		VertFrontRightDown = GameObject.Find ("VertFrontRightDown");
		VertFrontLeftUp = GameObject.Find ("VertFrontLeftUp");
		VertFrontLeftDown = GameObject.Find ("VertFrontLeftDown");
		VertBackRightUp = GameObject.Find ("VertBackRightUp");
		VertBackRightDown = GameObject.Find ("VertBackRightDown");
		VertBackLeftUp = GameObject.Find ("VertBackLeftUp");
		VertBackLeftDown = GameObject.Find ("VertBackLeftDown");
		VertLeftRightUp = GameObject.Find ("VertLeftRightUp");
		VertLeftRightDown = GameObject.Find ("VertLeftRightDown");
		VertLeftLeftUp = GameObject.Find ("VertLeftLeftUp");
		VertLeftLeftDown = GameObject.Find ("VertLeftLeftDown");
		VertRightRightUp = GameObject.Find ("VertRightRightUp");
		VertRightRightDown = GameObject.Find ("VertRightRightDown");
		VertRightLeftUp = GameObject.Find ("VertRightLeftUp");
		VertRightLeftDown = GameObject.Find ("VertRightLeftDown");
		VertUpRightUp = GameObject.Find ("VertUpRightUp");
		VertUpRightDown = GameObject.Find ("VertUpRightDown");
		VertUpLeftUp = GameObject.Find ("VertUpLeftUp");
		VertUpLeftDown = GameObject.Find ("VertUpLeftDown");
		VertDownRightUp = GameObject.Find ("VertDownRightUp");
		VertDownRightDown = GameObject.Find ("VertDownRightDown");
		VertDownLeftUp = GameObject.Find ("VertDownLeftUp");
		VertDownLeftDown = GameObject.Find ("VertDownLeftDown");

		Cent1 = GameObject.Find("Cent1");
		Cent2 = GameObject.Find("Cent2");
		Cent3 = GameObject.Find("Cent3");
		Cent4 = GameObject.Find("Cent4");
		Cent5 = GameObject.Find("Cent5");
		Cent6 = GameObject.Find("Cent6");

		Spig1 = GameObject.Find("Spig1");
		Spig2 = GameObject.Find("Spig2");
		Spig3 = GameObject.Find("Spig3");
		Spig4 = GameObject.Find("Spig4");
		Spig5 = GameObject.Find("Spig5");
		Spig6 = GameObject.Find("Spig6");
		Spig7 = GameObject.Find("Spig7");
		Spig8 = GameObject.Find("Spig8");
		Spig9 = GameObject.Find("Spig9");
		Spig10 = GameObject.Find("Spig10");
		Spig11 = GameObject.Find("Spig11");
		Spig12 = GameObject.Find("Spig12");

		Vert1 = GameObject.Find("Vert1");
		Vert2 = GameObject.Find("Vert2");
		Vert3 = GameObject.Find("Vert3");
		Vert4 = GameObject.Find("Vert4");
		Vert5 = GameObject.Find("Vert5");
		Vert6 = GameObject.Find("Vert6");
		Vert7 = GameObject.Find("Vert7");
		Vert8 = GameObject.Find("Vert8");

		m_Animatore = GameObject.Find ("Animazioni").GetComponent<Animatore> ();
	}

	public void FrontOrario(){
		Cent1.SetActive (false);
		Spig1.SetActive (false);
		Spig2.SetActive (false);
		Spig3.SetActive (false);
		Spig4.SetActive (false);
		Vert1.SetActive (false);
		Vert2.SetActive (false);
		Vert3.SetActive (false);
		Vert4.SetActive (false);

		if (m_Orario)
			m_Animatore.Front (VertFrontLeftUp.GetComponent<Renderer> ().material.color,
				VertFrontRightUp.GetComponent<Renderer> ().material.color,
				VertFrontLeftDown.GetComponent<Renderer> ().material.color,
				VertFrontRightDown.GetComponent<Renderer> ().material.color,
				VertLeftRightUp.GetComponent<Renderer> ().material.color,
				VertLeftRightDown.GetComponent<Renderer> ().material.color,
				VertRightLeftUp.GetComponent<Renderer> ().material.color,
				VertRightLeftDown.GetComponent<Renderer> ().material.color,
				VertUpLeftDown.GetComponent<Renderer> ().material.color,
				VertUpRightDown.GetComponent<Renderer> ().material.color,
				VertDownLeftUp.GetComponent<Renderer> ().material.color,
				VertDownRightUp.GetComponent<Renderer> ().material.color,
				SpigFrontUp.GetComponent<Renderer> ().material.color,
				SpigFrontDown.GetComponent<Renderer> ().material.color,
				SpigFrontLeft.GetComponent<Renderer> ().material.color,
				SpigFrontRight.GetComponent<Renderer> ().material.color,
				SpigLeftRight.GetComponent<Renderer> ().material.color,
				SpigRightLeft.GetComponent<Renderer> ().material.color,
				SpigUpDown.GetComponent<Renderer> ().material.color,
				SpigDownUp.GetComponent<Renderer> ().material.color, true);

		Color temp = SpigFrontUp.GetComponent<Renderer> ().material.color;
		SpigFrontUp.GetComponent<Renderer> ().material.color = SpigFrontLeft.GetComponent<Renderer> ().material.color;
		SpigFrontLeft.GetComponent<Renderer> ().material.color = SpigFrontDown.GetComponent<Renderer> ().material.color;
		SpigFrontDown.GetComponent<Renderer> ().material.color = SpigFrontRight.GetComponent<Renderer> ().material.color;
		SpigFrontRight.GetComponent<Renderer> ().material.color = temp;

		temp = VertFrontRightUp.GetComponent<Renderer> ().material.color;
		VertFrontRightUp.GetComponent<Renderer> ().material.color = VertFrontLeftUp.GetComponent<Renderer> ().material.color;
		VertFrontLeftUp.GetComponent<Renderer> ().material.color = VertFrontLeftDown.GetComponent<Renderer> ().material.color;
		VertFrontLeftDown.GetComponent<Renderer> ().material.color = VertFrontRightDown.GetComponent<Renderer> ().material.color;
		VertFrontRightDown.GetComponent<Renderer> ().material.color = temp;

		Color temp1 = VertUpLeftDown.GetComponent<Renderer> ().material.color;
		Color temp2 = SpigUpDown.GetComponent<Renderer> ().material.color;
		Color temp3 = VertUpRightDown.GetComponent<Renderer> ().material.color;

		VertUpLeftDown.GetComponent<Renderer> ().material.color = VertLeftRightDown.GetComponent<Renderer> ().material.color;
		SpigUpDown.GetComponent<Renderer> ().material.color = SpigLeftRight.GetComponent<Renderer> ().material.color;
		VertUpRightDown.GetComponent<Renderer> ().material.color = VertLeftRightUp.GetComponent<Renderer> ().material.color;

		VertLeftRightDown.GetComponent<Renderer> ().material.color = VertDownRightUp.GetComponent<Renderer> ().material.color;
		SpigLeftRight.GetComponent<Renderer> ().material.color = SpigDownUp.GetComponent<Renderer> ().material.color;
		VertLeftRightUp.GetComponent<Renderer> ().material.color = VertDownLeftUp.GetComponent<Renderer> ().material.color;

		VertDownRightUp.GetComponent<Renderer> ().material.color = VertRightLeftUp.GetComponent<Renderer> ().material.color;
		SpigDownUp.GetComponent<Renderer> ().material.color = SpigRightLeft.GetComponent<Renderer> ().material.color;
		VertDownLeftUp.GetComponent<Renderer> ().material.color = VertRightLeftDown.GetComponent<Renderer> ().material.color;

		VertRightLeftUp.GetComponent<Renderer> ().material.color = temp1;
		SpigRightLeft.GetComponent<Renderer> ().material.color = temp2;
		VertRightLeftDown.GetComponent<Renderer> ().material.color = temp3;

	}

	public void FrontAntioriario(){
		Cent1.SetActive (false);
		Spig1.SetActive (false);
		Spig2.SetActive (false);
		Spig3.SetActive (false);
		Spig4.SetActive (false);
		Vert1.SetActive (false);
		Vert2.SetActive (false);
		Vert3.SetActive (false);
		Vert4.SetActive (false);

		m_Animatore.Front (VertFrontLeftUp.GetComponent<Renderer> ().material.color,
			VertFrontRightUp.GetComponent<Renderer> ().material.color,
			VertFrontLeftDown.GetComponent<Renderer> ().material.color,
			VertFrontRightDown.GetComponent<Renderer> ().material.color,
			VertLeftRightUp.GetComponent<Renderer> ().material.color,
			VertLeftRightDown.GetComponent<Renderer> ().material.color,
			VertRightLeftUp.GetComponent<Renderer> ().material.color,
			VertRightLeftDown.GetComponent<Renderer> ().material.color,
			VertUpLeftDown.GetComponent<Renderer> ().material.color,
			VertUpRightDown.GetComponent<Renderer> ().material.color,
			VertDownLeftUp.GetComponent<Renderer> ().material.color,
			VertDownRightUp.GetComponent<Renderer> ().material.color,
			SpigFrontUp.GetComponent<Renderer> ().material.color,
			SpigFrontDown.GetComponent<Renderer> ().material.color,
			SpigFrontLeft.GetComponent<Renderer> ().material.color,
			SpigFrontRight.GetComponent<Renderer> ().material.color,
			SpigLeftRight.GetComponent<Renderer> ().material.color,
			SpigRightLeft.GetComponent<Renderer> ().material.color,
			SpigUpDown.GetComponent<Renderer> ().material.color,
			SpigDownUp.GetComponent<Renderer> ().material.color, false);

		m_Orario = false;
		for (int volta = 0; volta < 3; volta++) {
			FrontOrario ();
		}
		m_Orario = true;
	}

	public void BackOrario(){
		Cent4.SetActive (false);
		Spig6.SetActive (false);
		Spig9.SetActive (false);
		Spig11.SetActive (false);
		Spig12.SetActive (false);
		Vert5.SetActive (false);
		Vert6.SetActive (false);
		Vert7.SetActive (false);
		Vert8.SetActive (false);

		if (m_Orario)
			m_Animatore.Back (VertBackLeftUp.GetComponent<Renderer> ().material.color,
				VertBackRightUp.GetComponent<Renderer> ().material.color,
				VertBackLeftDown.GetComponent<Renderer> ().material.color,
				VertBackRightDown.GetComponent<Renderer> ().material.color,
				VertRightRightUp.GetComponent<Renderer> ().material.color,
				VertRightRightDown.GetComponent<Renderer> ().material.color,
				VertLeftLeftUp.GetComponent<Renderer> ().material.color,
				VertLeftLeftDown.GetComponent<Renderer> ().material.color,
				VertUpRightUp.GetComponent<Renderer> ().material.color,
				VertUpLeftUp.GetComponent<Renderer> ().material.color,
				VertDownRightDown.GetComponent<Renderer> ().material.color,
				VertDownLeftDown.GetComponent<Renderer> ().material.color,
				SpigBackUp.GetComponent<Renderer> ().material.color,
				SpigBackDown.GetComponent<Renderer> ().material.color,
				SpigBackLeft.GetComponent<Renderer> ().material.color,
				SpigBackRight.GetComponent<Renderer> ().material.color,
				SpigRightRight.GetComponent<Renderer> ().material.color,
				SpigLeftLeft.GetComponent<Renderer> ().material.color,
				SpigUpUp.GetComponent<Renderer> ().material.color,
				SpigDownDown.GetComponent<Renderer> ().material.color, true);
		
		Color temp = SpigBackUp.GetComponent<Renderer> ().material.color;
		SpigBackUp.GetComponent<Renderer> ().material.color = SpigBackLeft.GetComponent<Renderer> ().material.color;
		SpigBackLeft.GetComponent<Renderer> ().material.color = SpigBackDown.GetComponent<Renderer> ().material.color;
		SpigBackDown.GetComponent<Renderer> ().material.color = SpigBackRight.GetComponent<Renderer> ().material.color;
		SpigBackRight.GetComponent<Renderer> ().material.color = temp;

		temp = VertBackRightUp.GetComponent<Renderer> ().material.color;
		VertBackRightUp.GetComponent<Renderer> ().material.color = VertBackLeftUp.GetComponent<Renderer> ().material.color;
		VertBackLeftUp.GetComponent<Renderer> ().material.color = VertBackLeftDown.GetComponent<Renderer> ().material.color;
		VertBackLeftDown.GetComponent<Renderer> ().material.color = VertBackRightDown.GetComponent<Renderer> ().material.color;
		VertBackRightDown.GetComponent<Renderer> ().material.color = temp;

		Color temp1 = VertUpLeftUp.GetComponent<Renderer> ().material.color;
		Color temp2 = SpigUpUp.GetComponent<Renderer> ().material.color;
		Color temp3 = VertUpRightUp.GetComponent<Renderer> ().material.color;

		VertUpLeftUp.GetComponent<Renderer> ().material.color = VertRightRightUp.GetComponent<Renderer> ().material.color;
		SpigUpUp.GetComponent<Renderer> ().material.color = SpigRightRight.GetComponent<Renderer> ().material.color;
		VertUpRightUp.GetComponent<Renderer> ().material.color = VertRightRightDown.GetComponent<Renderer> ().material.color;

		VertRightRightUp.GetComponent<Renderer> ().material.color = VertDownRightDown.GetComponent<Renderer> ().material.color;
		SpigRightRight.GetComponent<Renderer> ().material.color = SpigDownDown.GetComponent<Renderer> ().material.color;
		VertRightRightDown.GetComponent<Renderer> ().material.color = VertDownLeftDown.GetComponent<Renderer> ().material.color;

		VertDownRightDown.GetComponent<Renderer> ().material.color = VertLeftLeftDown.GetComponent<Renderer> ().material.color;
		SpigDownDown.GetComponent<Renderer> ().material.color = SpigLeftLeft.GetComponent<Renderer> ().material.color;
		VertDownLeftDown.GetComponent<Renderer> ().material.color = VertLeftLeftUp.GetComponent<Renderer> ().material.color;

		VertLeftLeftDown.GetComponent<Renderer> ().material.color = temp1;
		SpigLeftLeft.GetComponent<Renderer> ().material.color = temp2;
		VertLeftLeftUp.GetComponent<Renderer> ().material.color = temp3;
		
	}

	public void BackAntioriario(){
		Cent4.SetActive (false);
		Spig6.SetActive (false);
		Spig9.SetActive (false);
		Spig11.SetActive (false);
		Spig12.SetActive (false);
		Vert5.SetActive (false);
		Vert6.SetActive (false);
		Vert7.SetActive (false);
		Vert8.SetActive (false);

		m_Animatore.Back (VertBackLeftUp.GetComponent<Renderer> ().material.color,
			VertBackRightUp.GetComponent<Renderer> ().material.color,
			VertBackLeftDown.GetComponent<Renderer> ().material.color,
			VertBackRightDown.GetComponent<Renderer> ().material.color,
			VertRightRightUp.GetComponent<Renderer> ().material.color,
			VertRightRightDown.GetComponent<Renderer> ().material.color,
			VertLeftLeftUp.GetComponent<Renderer> ().material.color,
			VertLeftLeftDown.GetComponent<Renderer> ().material.color,
			VertUpRightUp.GetComponent<Renderer> ().material.color,
			VertUpLeftUp.GetComponent<Renderer> ().material.color,
			VertDownRightDown.GetComponent<Renderer> ().material.color,
			VertDownLeftDown.GetComponent<Renderer> ().material.color,
			SpigBackUp.GetComponent<Renderer> ().material.color,
			SpigBackDown.GetComponent<Renderer> ().material.color,
			SpigBackLeft.GetComponent<Renderer> ().material.color,
			SpigBackRight.GetComponent<Renderer> ().material.color,
			SpigRightRight.GetComponent<Renderer> ().material.color,
			SpigLeftLeft.GetComponent<Renderer> ().material.color,
			SpigUpUp.GetComponent<Renderer> ().material.color,
			SpigDownDown.GetComponent<Renderer> ().material.color, false);

		m_Orario = false;
		for (int volta = 0; volta < 3; volta++) {
			BackOrario ();
		}
		m_Orario = true;
	}

	public void RightOrario(){
		Cent3.SetActive (false);
		Spig3.SetActive (false);
		Spig8.SetActive (false);
		Spig9.SetActive (false);
		Spig10.SetActive (false);
		Vert2.SetActive (false);
		Vert4.SetActive (false);
		Vert6.SetActive (false);
		Vert8.SetActive (false);

		if (m_Orario)
			m_Animatore.Right (VertRightLeftUp.GetComponent<Renderer> ().material.color,
				VertRightRightUp.GetComponent<Renderer> ().material.color,
				VertRightLeftDown.GetComponent<Renderer> ().material.color,
				VertRightRightDown.GetComponent<Renderer> ().material.color,
				VertFrontRightUp.GetComponent<Renderer> ().material.color,
				VertFrontRightDown.GetComponent<Renderer> ().material.color,
				VertBackLeftUp.GetComponent<Renderer> ().material.color,
				VertBackLeftDown.GetComponent<Renderer> ().material.color,
				VertUpRightDown.GetComponent<Renderer> ().material.color,
				VertUpRightUp.GetComponent<Renderer> ().material.color,
				VertDownRightUp.GetComponent<Renderer> ().material.color,
				VertDownRightDown.GetComponent<Renderer> ().material.color,
				SpigRightUp.GetComponent<Renderer> ().material.color,
				SpigRightDown.GetComponent<Renderer> ().material.color,
				SpigRightLeft.GetComponent<Renderer> ().material.color,
				SpigRightRight.GetComponent<Renderer> ().material.color,
				SpigFrontRight.GetComponent<Renderer> ().material.color,
				SpigBackLeft.GetComponent<Renderer> ().material.color,
				SpigUpRight.GetComponent<Renderer> ().material.color,
				SpigDownRight.GetComponent<Renderer> ().material.color, true);
		
		Color temp = SpigRightUp.GetComponent<Renderer> ().material.color;
		SpigRightUp.GetComponent<Renderer> ().material.color = SpigRightLeft.GetComponent<Renderer> ().material.color;
		SpigRightLeft.GetComponent<Renderer> ().material.color = SpigRightDown.GetComponent<Renderer> ().material.color;
		SpigRightDown.GetComponent<Renderer> ().material.color = SpigRightRight.GetComponent<Renderer> ().material.color;
		SpigRightRight.GetComponent<Renderer> ().material.color = temp;

		temp = VertRightRightUp.GetComponent<Renderer> ().material.color;
		VertRightRightUp.GetComponent<Renderer> ().material.color = VertRightLeftUp.GetComponent<Renderer> ().material.color;
		VertRightLeftUp.GetComponent<Renderer> ().material.color = VertRightLeftDown.GetComponent<Renderer> ().material.color;
		VertRightLeftDown.GetComponent<Renderer> ().material.color = VertRightRightDown.GetComponent<Renderer> ().material.color;
		VertRightRightDown.GetComponent<Renderer> ().material.color = temp;

		Color temp1 = VertUpRightUp.GetComponent<Renderer> ().material.color;
		Color temp2 = SpigUpRight.GetComponent<Renderer> ().material.color;
		Color temp3 = VertUpRightDown.GetComponent<Renderer> ().material.color;

		VertUpRightUp.GetComponent<Renderer> ().material.color = VertFrontRightUp.GetComponent<Renderer> ().material.color;
		SpigUpRight.GetComponent<Renderer> ().material.color = SpigFrontRight.GetComponent<Renderer> ().material.color;
		VertUpRightDown.GetComponent<Renderer> ().material.color = VertFrontRightDown.GetComponent<Renderer> ().material.color;

		VertFrontRightUp.GetComponent<Renderer> ().material.color = VertDownRightUp.GetComponent<Renderer> ().material.color;
		SpigFrontRight.GetComponent<Renderer> ().material.color = SpigDownRight.GetComponent<Renderer> ().material.color;
		VertFrontRightDown.GetComponent<Renderer> ().material.color = VertDownRightDown.GetComponent<Renderer> ().material.color;

		VertDownRightUp.GetComponent<Renderer> ().material.color = VertBackLeftDown.GetComponent<Renderer> ().material.color;
		SpigDownRight.GetComponent<Renderer> ().material.color = SpigBackLeft.GetComponent<Renderer> ().material.color;
		VertDownRightDown.GetComponent<Renderer> ().material.color = VertBackLeftUp.GetComponent<Renderer> ().material.color;

		VertBackLeftDown.GetComponent<Renderer> ().material.color = temp1;
		SpigBackLeft.GetComponent<Renderer> ().material.color = temp2;
		VertBackLeftUp.GetComponent<Renderer> ().material.color = temp3;
	}

	public void RightAntioriario(){
		Cent3.SetActive (false);
		Spig3.SetActive (false);
		Spig8.SetActive (false);
		Spig9.SetActive (false);
		Spig10.SetActive (false);
		Vert2.SetActive (false);
		Vert4.SetActive (false);
		Vert6.SetActive (false);
		Vert8.SetActive (false);

		m_Animatore.Right (VertRightLeftUp.GetComponent<Renderer> ().material.color,
			VertRightRightUp.GetComponent<Renderer> ().material.color,
			VertRightLeftDown.GetComponent<Renderer> ().material.color,
			VertRightRightDown.GetComponent<Renderer> ().material.color,
			VertFrontRightUp.GetComponent<Renderer> ().material.color,
			VertFrontRightDown.GetComponent<Renderer> ().material.color,
			VertBackLeftUp.GetComponent<Renderer> ().material.color,
			VertBackLeftDown.GetComponent<Renderer> ().material.color,
			VertUpRightDown.GetComponent<Renderer> ().material.color,
			VertUpRightUp.GetComponent<Renderer> ().material.color,
			VertDownRightUp.GetComponent<Renderer> ().material.color,
			VertDownRightDown.GetComponent<Renderer> ().material.color,
			SpigRightUp.GetComponent<Renderer> ().material.color,
			SpigRightDown.GetComponent<Renderer> ().material.color,
			SpigRightLeft.GetComponent<Renderer> ().material.color,
			SpigRightRight.GetComponent<Renderer> ().material.color,
			SpigFrontRight.GetComponent<Renderer> ().material.color,
			SpigBackLeft.GetComponent<Renderer> ().material.color,
			SpigUpRight.GetComponent<Renderer> ().material.color,
			SpigDownRight.GetComponent<Renderer> ().material.color, false);

		m_Orario = false;
		for (int volta = 0; volta < 3; volta++) {
			RightOrario ();
		}
		m_Orario = true;
	}

	public void LeftOrario(){
		Cent2.SetActive (false);
		Spig2.SetActive (false);
		Spig5.SetActive (false);
		Spig6.SetActive (false);
		Spig7.SetActive (false);
		Vert1.SetActive (false);
		Vert3.SetActive (false);
		Vert5.SetActive (false);
		Vert7.SetActive (false);

		if (m_Orario)
			m_Animatore.Left (VertLeftLeftUp.GetComponent<Renderer> ().material.color,
				VertLeftRightUp.GetComponent<Renderer> ().material.color,
				VertLeftLeftDown.GetComponent<Renderer> ().material.color,
				VertLeftRightDown.GetComponent<Renderer> ().material.color,
				VertBackRightUp.GetComponent<Renderer> ().material.color,
				VertBackRightDown.GetComponent<Renderer> ().material.color,
				VertFrontLeftUp.GetComponent<Renderer> ().material.color,
				VertFrontLeftDown.GetComponent<Renderer> ().material.color,
				VertUpLeftUp.GetComponent<Renderer> ().material.color,
				VertUpLeftDown.GetComponent<Renderer> ().material.color,
				VertDownLeftDown.GetComponent<Renderer> ().material.color,
				VertDownLeftUp.GetComponent<Renderer> ().material.color,
				SpigLeftUp.GetComponent<Renderer> ().material.color,
				SpigLeftDown.GetComponent<Renderer> ().material.color,
				SpigLeftLeft.GetComponent<Renderer> ().material.color,
				SpigLeftRight.GetComponent<Renderer> ().material.color,
				SpigBackRight.GetComponent<Renderer> ().material.color,
				SpigFrontLeft.GetComponent<Renderer> ().material.color,
				SpigUpLeft.GetComponent<Renderer> ().material.color,
				SpigDownLeft.GetComponent<Renderer> ().material.color, true);
		
		Color temp = SpigLeftUp.GetComponent<Renderer> ().material.color;
		SpigLeftUp.GetComponent<Renderer> ().material.color = SpigLeftLeft.GetComponent<Renderer> ().material.color;
		SpigLeftLeft.GetComponent<Renderer> ().material.color = SpigLeftDown.GetComponent<Renderer> ().material.color;
		SpigLeftDown.GetComponent<Renderer> ().material.color = SpigLeftRight.GetComponent<Renderer> ().material.color;
		SpigLeftRight.GetComponent<Renderer> ().material.color = temp;

		temp = VertLeftRightUp.GetComponent<Renderer> ().material.color;
		VertLeftRightUp.GetComponent<Renderer> ().material.color = VertLeftLeftUp.GetComponent<Renderer> ().material.color;
		VertLeftLeftUp.GetComponent<Renderer> ().material.color = VertLeftLeftDown.GetComponent<Renderer> ().material.color;
		VertLeftLeftDown.GetComponent<Renderer> ().material.color = VertLeftRightDown.GetComponent<Renderer> ().material.color;
		VertLeftRightDown.GetComponent<Renderer> ().material.color = temp;

		Color temp1 = VertUpLeftUp.GetComponent<Renderer> ().material.color;
		Color temp2 = SpigUpLeft.GetComponent<Renderer> ().material.color;
		Color temp3 = VertUpLeftDown.GetComponent<Renderer> ().material.color;

		VertUpLeftUp.GetComponent<Renderer> ().material.color = VertBackRightDown.GetComponent<Renderer> ().material.color;
		SpigUpLeft.GetComponent<Renderer> ().material.color = SpigBackRight.GetComponent<Renderer> ().material.color;
		VertUpLeftDown.GetComponent<Renderer> ().material.color = VertBackRightUp.GetComponent<Renderer> ().material.color;

		VertBackRightDown.GetComponent<Renderer> ().material.color = VertDownLeftUp.GetComponent<Renderer> ().material.color;
		SpigBackRight.GetComponent<Renderer> ().material.color = SpigDownLeft.GetComponent<Renderer> ().material.color;
		VertBackRightUp.GetComponent<Renderer> ().material.color = VertDownLeftDown.GetComponent<Renderer> ().material.color;

		VertDownLeftUp.GetComponent<Renderer> ().material.color = VertFrontLeftUp.GetComponent<Renderer> ().material.color;
		SpigDownLeft.GetComponent<Renderer> ().material.color = SpigFrontLeft.GetComponent<Renderer> ().material.color;
		VertDownLeftDown.GetComponent<Renderer> ().material.color = VertFrontLeftDown.GetComponent<Renderer> ().material.color;

		VertFrontLeftUp.GetComponent<Renderer> ().material.color = temp1;
		SpigFrontLeft.GetComponent<Renderer> ().material.color = temp2;
		VertFrontLeftDown.GetComponent<Renderer> ().material.color = temp3;

	}

	public void LeftAntioriario(){
		Cent2.SetActive (false);
		Spig2.SetActive (false);
		Spig5.SetActive (false);
		Spig6.SetActive (false);
		Spig7.SetActive (false);
		Vert1.SetActive (false);
		Vert3.SetActive (false);
		Vert5.SetActive (false);
		Vert7.SetActive (false);

		m_Animatore.Left (VertLeftLeftUp.GetComponent<Renderer> ().material.color,
			VertLeftRightUp.GetComponent<Renderer> ().material.color,
			VertLeftLeftDown.GetComponent<Renderer> ().material.color,
			VertLeftRightDown.GetComponent<Renderer> ().material.color,
			VertBackRightUp.GetComponent<Renderer> ().material.color,
			VertBackRightDown.GetComponent<Renderer> ().material.color,
			VertFrontLeftUp.GetComponent<Renderer> ().material.color,
			VertFrontLeftDown.GetComponent<Renderer> ().material.color,
			VertUpLeftUp.GetComponent<Renderer> ().material.color,
			VertUpLeftDown.GetComponent<Renderer> ().material.color,
			VertDownLeftDown.GetComponent<Renderer> ().material.color,
			VertDownLeftUp.GetComponent<Renderer> ().material.color,
			SpigLeftUp.GetComponent<Renderer> ().material.color,
			SpigLeftDown.GetComponent<Renderer> ().material.color,
			SpigLeftLeft.GetComponent<Renderer> ().material.color,
			SpigLeftRight.GetComponent<Renderer> ().material.color,
			SpigBackRight.GetComponent<Renderer> ().material.color,
			SpigFrontLeft.GetComponent<Renderer> ().material.color,
			SpigUpLeft.GetComponent<Renderer> ().material.color,
			SpigDownLeft.GetComponent<Renderer> ().material.color, false);

		m_Orario = false;
		for (int volta = 0; volta < 3; volta++) {
			LeftOrario ();
		}
		m_Orario = true;
	}

	public void UpOrario(){
		Cent5.SetActive (false);
		Spig1.SetActive (false);
		Spig5.SetActive (false);
		Spig8.SetActive (false);
		Spig11.SetActive (false);
		Vert1.SetActive (false);
		Vert2.SetActive (false);
		Vert5.SetActive (false);
		Vert6.SetActive (false);

		if (m_Orario)
			m_Animatore.Up (VertUpLeftUp.GetComponent<Renderer> ().material.color,
				VertUpRightUp.GetComponent<Renderer> ().material.color,
				VertUpLeftDown.GetComponent<Renderer> ().material.color,
				VertUpRightDown.GetComponent<Renderer> ().material.color,
				VertLeftLeftUp.GetComponent<Renderer> ().material.color,
				VertLeftRightUp.GetComponent<Renderer> ().material.color,
				VertRightRightUp.GetComponent<Renderer> ().material.color,
				VertRightLeftUp.GetComponent<Renderer> ().material.color,
				VertBackRightUp.GetComponent<Renderer> ().material.color,
				VertBackLeftUp.GetComponent<Renderer> ().material.color,
				VertFrontLeftUp.GetComponent<Renderer> ().material.color,
				VertFrontRightUp.GetComponent<Renderer> ().material.color,
				SpigUpUp.GetComponent<Renderer> ().material.color,
				SpigUpDown.GetComponent<Renderer> ().material.color,
				SpigUpLeft.GetComponent<Renderer> ().material.color,
				SpigUpRight.GetComponent<Renderer> ().material.color,
				SpigLeftUp.GetComponent<Renderer> ().material.color,
				SpigRightUp.GetComponent<Renderer> ().material.color,
				SpigBackUp.GetComponent<Renderer> ().material.color,
				SpigFrontUp.GetComponent<Renderer> ().material.color, true);
		
		Color temp = SpigUpUp.GetComponent<Renderer> ().material.color;
		SpigUpUp.GetComponent<Renderer> ().material.color = SpigUpLeft.GetComponent<Renderer> ().material.color;
		SpigUpLeft.GetComponent<Renderer> ().material.color = SpigUpDown.GetComponent<Renderer> ().material.color;
		SpigUpDown.GetComponent<Renderer> ().material.color = SpigUpRight.GetComponent<Renderer> ().material.color;
		SpigUpRight.GetComponent<Renderer> ().material.color = temp;

		temp = VertUpRightUp.GetComponent<Renderer> ().material.color;
		VertUpRightUp.GetComponent<Renderer> ().material.color = VertUpLeftUp.GetComponent<Renderer> ().material.color;
		VertUpLeftUp.GetComponent<Renderer> ().material.color = VertUpLeftDown.GetComponent<Renderer> ().material.color;
		VertUpLeftDown.GetComponent<Renderer> ().material.color = VertUpRightDown.GetComponent<Renderer> ().material.color;
		VertUpRightDown.GetComponent<Renderer> ().material.color = temp;

		Color temp1 = VertFrontLeftUp.GetComponent<Renderer> ().material.color;
		Color temp2 = SpigFrontUp.GetComponent<Renderer> ().material.color;
		Color temp3 = VertFrontRightUp.GetComponent<Renderer> ().material.color;

		VertFrontLeftUp.GetComponent<Renderer> ().material.color = VertRightLeftUp.GetComponent<Renderer> ().material.color;
		SpigFrontUp.GetComponent<Renderer> ().material.color = SpigRightUp.GetComponent<Renderer> ().material.color;
		VertFrontRightUp.GetComponent<Renderer> ().material.color = VertRightRightUp.GetComponent<Renderer> ().material.color;

		VertRightLeftUp.GetComponent<Renderer> ().material.color = VertBackLeftUp.GetComponent<Renderer> ().material.color;
		SpigRightUp.GetComponent<Renderer> ().material.color = SpigBackUp.GetComponent<Renderer> ().material.color;
		VertRightRightUp.GetComponent<Renderer> ().material.color = VertBackRightUp.GetComponent<Renderer> ().material.color;

		VertBackLeftUp.GetComponent<Renderer> ().material.color = VertLeftLeftUp.GetComponent<Renderer> ().material.color;
		SpigBackUp.GetComponent<Renderer> ().material.color = SpigLeftUp.GetComponent<Renderer> ().material.color;
		VertBackRightUp.GetComponent<Renderer> ().material.color = VertLeftRightUp.GetComponent<Renderer> ().material.color;

		VertLeftLeftUp.GetComponent<Renderer> ().material.color = temp1;
		SpigLeftUp.GetComponent<Renderer> ().material.color = temp2;
		VertLeftRightUp.GetComponent<Renderer> ().material.color = temp3;

	}

	public void UpAntioriario(){
		Cent5.SetActive (false);
		Spig1.SetActive (false);
		Spig5.SetActive (false);
		Spig8.SetActive (false);
		Spig11.SetActive (false);
		Vert1.SetActive (false);
		Vert2.SetActive (false);
		Vert5.SetActive (false);
		Vert6.SetActive (false);

		m_Animatore.Up (VertUpLeftUp.GetComponent<Renderer> ().material.color,
			VertUpRightUp.GetComponent<Renderer> ().material.color,
			VertUpLeftDown.GetComponent<Renderer> ().material.color,
			VertUpRightDown.GetComponent<Renderer> ().material.color,
			VertLeftLeftUp.GetComponent<Renderer> ().material.color,
			VertLeftRightUp.GetComponent<Renderer> ().material.color,
			VertRightRightUp.GetComponent<Renderer> ().material.color,
			VertRightLeftUp.GetComponent<Renderer> ().material.color,
			VertBackRightUp.GetComponent<Renderer> ().material.color,
			VertBackLeftUp.GetComponent<Renderer> ().material.color,
			VertFrontLeftUp.GetComponent<Renderer> ().material.color,
			VertFrontRightUp.GetComponent<Renderer> ().material.color,
			SpigUpUp.GetComponent<Renderer> ().material.color,
			SpigUpDown.GetComponent<Renderer> ().material.color,
			SpigUpLeft.GetComponent<Renderer> ().material.color,
			SpigUpRight.GetComponent<Renderer> ().material.color,
			SpigLeftUp.GetComponent<Renderer> ().material.color,
			SpigRightUp.GetComponent<Renderer> ().material.color,
			SpigBackUp.GetComponent<Renderer> ().material.color,
			SpigFrontUp.GetComponent<Renderer> ().material.color, false);

		m_Orario = false;
		for (int volta = 0; volta < 3; volta++) {
			UpOrario ();
		}
		m_Orario = true;
	}

	public void DownOrario(){
		Cent6.SetActive (false);
		Spig4.SetActive (false);
		Spig7.SetActive (false);
		Spig10.SetActive (false);
		Spig12.SetActive (false);
		Vert3.SetActive (false);
		Vert4.SetActive (false);
		Vert7.SetActive (false);
		Vert8.SetActive (false);

		if (m_Orario)
			m_Animatore.Down (VertDownLeftUp.GetComponent<Renderer> ().material.color,
				VertDownRightUp.GetComponent<Renderer> ().material.color,
				VertDownLeftDown.GetComponent<Renderer> ().material.color,
				VertDownRightDown.GetComponent<Renderer> ().material.color,
				VertLeftRightDown.GetComponent<Renderer> ().material.color,
				VertLeftLeftDown.GetComponent<Renderer> ().material.color,
				VertRightLeftDown.GetComponent<Renderer> ().material.color,
				VertRightRightDown.GetComponent<Renderer> ().material.color,
				VertFrontLeftDown.GetComponent<Renderer> ().material.color,
				VertFrontRightDown.GetComponent<Renderer> ().material.color,
				VertBackRightDown.GetComponent<Renderer> ().material.color,
				VertBackLeftDown.GetComponent<Renderer> ().material.color,
				SpigDownUp.GetComponent<Renderer> ().material.color,
				SpigDownDown.GetComponent<Renderer> ().material.color,
				SpigDownLeft.GetComponent<Renderer> ().material.color,
				SpigDownRight.GetComponent<Renderer> ().material.color,
				SpigLeftDown.GetComponent<Renderer> ().material.color,
				SpigRightDown.GetComponent<Renderer> ().material.color,
				SpigFrontDown.GetComponent<Renderer> ().material.color,
				SpigBackDown.GetComponent<Renderer> ().material.color, true);
		
		Color temp = SpigDownUp.GetComponent<Renderer> ().material.color;
		SpigDownUp.GetComponent<Renderer> ().material.color = SpigDownLeft.GetComponent<Renderer> ().material.color;
		SpigDownLeft.GetComponent<Renderer> ().material.color = SpigDownDown.GetComponent<Renderer> ().material.color;
		SpigDownDown.GetComponent<Renderer> ().material.color = SpigDownRight.GetComponent<Renderer> ().material.color;
		SpigDownRight.GetComponent<Renderer> ().material.color = temp;

		temp = VertDownRightUp.GetComponent<Renderer> ().material.color;
		VertDownRightUp.GetComponent<Renderer> ().material.color = VertDownLeftUp.GetComponent<Renderer> ().material.color;
		VertDownLeftUp.GetComponent<Renderer> ().material.color = VertDownLeftDown.GetComponent<Renderer> ().material.color;
		VertDownLeftDown.GetComponent<Renderer> ().material.color = VertDownRightDown.GetComponent<Renderer> ().material.color;
		VertDownRightDown.GetComponent<Renderer> ().material.color = temp;

		Color temp1 = VertFrontLeftDown.GetComponent<Renderer> ().material.color;
		Color temp2 = SpigFrontDown.GetComponent<Renderer> ().material.color;
		Color temp3 = VertFrontRightDown.GetComponent<Renderer> ().material.color;

		VertFrontLeftDown.GetComponent<Renderer> ().material.color = VertLeftLeftDown.GetComponent<Renderer> ().material.color;
		SpigFrontDown.GetComponent<Renderer> ().material.color = SpigLeftDown.GetComponent<Renderer> ().material.color;
		VertFrontRightDown.GetComponent<Renderer> ().material.color = VertLeftRightDown.GetComponent<Renderer> ().material.color;

		VertLeftLeftDown.GetComponent<Renderer> ().material.color = VertBackLeftDown.GetComponent<Renderer> ().material.color;
		SpigLeftDown.GetComponent<Renderer> ().material.color = SpigBackDown.GetComponent<Renderer> ().material.color;
		VertLeftRightDown.GetComponent<Renderer> ().material.color = VertBackRightDown.GetComponent<Renderer> ().material.color;

		VertBackLeftDown.GetComponent<Renderer> ().material.color = VertRightLeftDown.GetComponent<Renderer> ().material.color;
		SpigBackDown.GetComponent<Renderer> ().material.color = SpigRightDown.GetComponent<Renderer> ().material.color;
		VertBackRightDown.GetComponent<Renderer> ().material.color = VertRightRightDown.GetComponent<Renderer> ().material.color;

		VertRightLeftDown.GetComponent<Renderer> ().material.color = temp1;
		SpigRightDown.GetComponent<Renderer> ().material.color = temp2;
		VertRightRightDown.GetComponent<Renderer> ().material.color = temp3;

	}

	public void DownAntioriario(){
		Cent6.SetActive (false);
		Spig4.SetActive (false);
		Spig7.SetActive (false);
		Spig10.SetActive (false);
		Spig12.SetActive (false);
		Vert3.SetActive (false);
		Vert4.SetActive (false);
		Vert7.SetActive (false);
		Vert8.SetActive (false);

		m_Animatore.Down (VertDownLeftUp.GetComponent<Renderer> ().material.color,
			VertDownRightUp.GetComponent<Renderer> ().material.color,
			VertDownLeftDown.GetComponent<Renderer> ().material.color,
			VertDownRightDown.GetComponent<Renderer> ().material.color,
			VertLeftRightDown.GetComponent<Renderer> ().material.color,
			VertLeftLeftDown.GetComponent<Renderer> ().material.color,
			VertRightLeftDown.GetComponent<Renderer> ().material.color,
			VertRightRightDown.GetComponent<Renderer> ().material.color,
			VertFrontLeftDown.GetComponent<Renderer> ().material.color,
			VertFrontRightDown.GetComponent<Renderer> ().material.color,
			VertBackRightDown.GetComponent<Renderer> ().material.color,
			VertBackLeftDown.GetComponent<Renderer> ().material.color,
			SpigDownUp.GetComponent<Renderer> ().material.color,
			SpigDownDown.GetComponent<Renderer> ().material.color,
			SpigDownLeft.GetComponent<Renderer> ().material.color,
			SpigDownRight.GetComponent<Renderer> ().material.color,
			SpigLeftDown.GetComponent<Renderer> ().material.color,
			SpigRightDown.GetComponent<Renderer> ().material.color,
			SpigFrontDown.GetComponent<Renderer> ().material.color,
			SpigBackDown.GetComponent<Renderer> ().material.color, false);
		
		m_Orario = false;
		for (int volta = 0; volta < 3; volta++) {
			DownOrario ();
		}
		m_Orario = true;
	}

	public void AccendiTuttiCubetti(){
		Cent1.SetActive (true);
		Cent2.SetActive (true);
		Cent3.SetActive (true);
		Cent4.SetActive (true);
		Cent5.SetActive (true);
		Cent6.SetActive (true);

		Spig1.SetActive (true);
		Spig2.SetActive (true);
		Spig3.SetActive (true);
		Spig4.SetActive (true);
		Spig5.SetActive (true);
		Spig6.SetActive (true);
		Spig7.SetActive (true);
		Spig8.SetActive (true);
		Spig9.SetActive (true);
		Spig10.SetActive (true);
		Spig11.SetActive (true);
		Spig12.SetActive (true);

		Vert1.SetActive (true);
		Vert2.SetActive (true);
		Vert3.SetActive (true);
		Vert4.SetActive (true);
		Vert5.SetActive (true);
		Vert6.SetActive (true);
		Vert7.SetActive (true);
		Vert8.SetActive (true);
	}

	public bool IsStatoIniziale(){
		return (
				SpigFrontUp.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				SpigFrontDown.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				SpigFrontLeft.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				SpigFrontRight.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				VertFrontLeftUp.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				VertFrontLeftDown.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				VertFrontRightUp.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&
				VertFrontRightDown.GetComponent<Renderer> ().material.color.Equals (CentFront.GetComponent<Renderer> ().material.color) &&

				SpigBackUp.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				SpigBackDown.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				SpigBackLeft.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				SpigBackRight.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				VertBackLeftUp.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				VertBackLeftDown.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				VertBackRightUp.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&
				VertBackRightDown.GetComponent<Renderer> ().material.color.Equals (CentBack.GetComponent<Renderer> ().material.color) &&

				SpigLeftUp.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				SpigLeftDown.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				SpigLeftLeft.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				SpigLeftRight.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				VertLeftLeftUp.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				VertLeftLeftDown.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				VertLeftRightUp.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&
				VertLeftRightDown.GetComponent<Renderer> ().material.color.Equals (CentLeft.GetComponent<Renderer> ().material.color) &&

				SpigRightUp.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				SpigRightDown.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				SpigRightLeft.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				SpigRightRight.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				VertRightLeftUp.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				VertRightLeftDown.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				VertRightRightUp.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&
				VertRightRightDown.GetComponent<Renderer> ().material.color.Equals (CentRight.GetComponent<Renderer> ().material.color) &&

				SpigUpUp.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				SpigUpDown.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				SpigUpLeft.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				SpigUpRight.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				VertUpLeftUp.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				VertUpLeftDown.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				VertUpRightUp.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&
				VertUpRightDown.GetComponent<Renderer> ().material.color.Equals (CentUp.GetComponent<Renderer> ().material.color) &&

				SpigDownUp.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				SpigDownDown.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				SpigDownLeft.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				SpigDownRight.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				VertDownLeftUp.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				VertDownLeftDown.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				VertDownRightUp.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color) &&
				VertDownRightDown.GetComponent<Renderer> ().material.color.Equals (CentDown.GetComponent<Renderer> ().material.color)
			);
	}

	public void ResetCubo(){
		SpigFrontUp.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		SpigFrontDown.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		SpigFrontLeft.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		SpigFrontRight.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		VertFrontLeftUp.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		VertFrontLeftDown.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		VertFrontRightUp.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;
		VertFrontRightDown.GetComponent<Renderer> ().material.color = CentFront.GetComponent<Renderer> ().material.color;

		SpigBackUp.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		SpigBackDown.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		SpigBackLeft.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		SpigBackRight.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		VertBackLeftUp.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		VertBackLeftDown.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		VertBackRightUp.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;
		VertBackRightDown.GetComponent<Renderer> ().material.color = CentBack.GetComponent<Renderer> ().material.color;

		SpigLeftUp.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		SpigLeftDown.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		SpigLeftLeft.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		SpigLeftRight.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		VertLeftLeftUp.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		VertLeftLeftDown.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		VertLeftRightUp.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;
		VertLeftRightDown.GetComponent<Renderer> ().material.color = CentLeft.GetComponent<Renderer> ().material.color;

		SpigRightUp.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		SpigRightDown.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		SpigRightLeft.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		SpigRightRight.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		VertRightLeftUp.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		VertRightLeftDown.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		VertRightRightUp.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;
		VertRightRightDown.GetComponent<Renderer> ().material.color = CentRight.GetComponent<Renderer> ().material.color;

		SpigUpUp.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		SpigUpDown.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		SpigUpLeft.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		SpigUpRight.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		VertUpLeftUp.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		VertUpLeftDown.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		VertUpRightUp.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;
		VertUpRightDown.GetComponent<Renderer> ().material.color = CentUp.GetComponent<Renderer> ().material.color;

		SpigDownUp.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		SpigDownDown.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		SpigDownLeft.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		SpigDownRight.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		VertDownLeftUp.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		VertDownLeftDown.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		VertDownRightUp.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
		VertDownRightDown.GetComponent<Renderer> ().material.color = CentDown.GetComponent<Renderer> ().material.color;
	}

	public Color getCentFrontColor(){
		return CentFront.GetComponent<Renderer> ().material.color;
	}

	public Color getCentBackColor(){
		return CentBack.GetComponent<Renderer> ().material.color;
	}

	public Color getCentRightColor(){
		return CentRight.GetComponent<Renderer> ().material.color;
	}

	public Color getCentLeftColor(){
		return CentLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getCentUpColor(){
		return CentUp.GetComponent<Renderer> ().material.color;
	}

	public Color getCentDownColor(){
		return CentDown.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigFrontUpColor(){
		return SpigFrontUp.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigFrontLeftColor(){
		return SpigFrontLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigFrontRightColor(){
		return SpigFrontRight.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigFrontDownColor(){
		return SpigFrontDown.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigBackUpColor(){
		return SpigBackUp.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigBackLeftColor(){
		return SpigBackLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigBackRightColor(){
		return SpigBackRight.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigBackDownColor(){
		return SpigBackDown.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigRightUpColor(){
		return SpigRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigRightLeftColor(){
		return SpigRightLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigRightRightColor(){
		return SpigRightRight.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigRightDownColor(){
		return SpigRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigLeftUpColor(){
		return SpigLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigLeftLeftColor(){
		return SpigLeftLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigLeftRightColor(){
		return SpigLeftRight.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigLeftDownColor(){
		return SpigLeftDown.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigUpUpColor(){
		return SpigUpUp.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigUpLeftColor(){
		return SpigUpLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigUpRightColor(){
		return SpigUpRight.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigUpDownColor(){
		return SpigUpDown.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigDownUpColor(){
		return SpigDownUp.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigDownLeftColor(){
		return SpigDownLeft.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigDownRightColor(){
		return SpigDownRight.GetComponent<Renderer> ().material.color;
	}

	public Color getSpigDownDownColor(){
		return SpigDownDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertFrontRightUpColor(){
		return VertFrontRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertFrontRightDownColor(){
		return VertFrontRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertFrontLeftUpColor(){
		return VertFrontLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertFrontLeftDownColor(){
		return VertFrontLeftDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertBackRightUpColor(){
		return VertBackRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertBackRightDownColor(){
		return VertBackRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertBackLeftUpColor(){
		return VertBackLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertBackLeftDownColor(){
		return VertBackLeftDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertLeftRightUpColor(){
		return VertLeftRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertLeftRightDownColor(){
		return VertLeftRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertLeftLeftUpColor(){
		return VertLeftLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertLeftLeftDownColor(){
		return VertLeftLeftDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertRightRightUpColor(){
		return VertRightRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertRightRightDownColor(){
		return VertRightRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertRightLeftUpColor(){
		return VertRightLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertRightLeftDownColor(){
		return VertRightLeftDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertUpRightUpColor(){
		return VertUpRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertUpRightDownColor(){
		return VertUpRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertUpLeftUpColor(){
		return VertUpLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertUpLeftDownColor(){
		return VertUpLeftDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertDownRightUpColor(){
		return VertDownRightUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertDownRightDownColor(){
		return VertDownRightDown.GetComponent<Renderer> ().material.color;
	}

	public Color getVertDownLeftUpColor(){
		return VertDownLeftUp.GetComponent<Renderer> ().material.color;
	}

	public Color getVertDownLeftDownColor(){
		return VertDownLeftDown.GetComponent<Renderer> ().material.color;
	}

	public void setCentFrontColor(Color newColor){
		CentFront.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setCentBackColor(Color newColor){
		CentBack.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setCentRightColor(Color newColor){
		CentRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setCentLeftColor(Color newColor){
		CentLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setCentUpColor(Color newColor){
		CentUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setCentDownColor(Color newColor){
		CentDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigFrontUpColor(Color newColor){
		SpigFrontUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigFrontLeftColor(Color newColor){
		SpigFrontLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigFrontRightColor(Color newColor){
		SpigFrontRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigFrontDownColor(Color newColor){
		SpigFrontDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigBackUpColor(Color newColor){
		SpigBackUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigBackLeftColor(Color newColor){
		SpigBackLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigBackRightColor(Color newColor){
		SpigBackRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigBackDownColor(Color newColor){
		SpigBackDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigRightUpColor(Color newColor){
		SpigRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigRightLeftColor(Color newColor){
		SpigRightLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigRightRightColor(Color newColor){
		SpigRightRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigRightDownColor(Color newColor){
		SpigRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigLeftUpColor(Color newColor){
		SpigLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigLeftLeftColor(Color newColor){
		SpigLeftLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigLeftRightColor(Color newColor){
		SpigLeftRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigLeftDownColor(Color newColor){
		SpigLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigUpUpColor(Color newColor){
		SpigUpUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigUpLeftColor(Color newColor){
		SpigUpLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigUpRightColor(Color newColor){
		SpigUpRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigUpDownColor(Color newColor){
		SpigUpDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigDownUpColor(Color newColor){
		SpigDownUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigDownLeftColor(Color newColor){
		SpigDownLeft.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigDownRightColor(Color newColor){
		SpigDownRight.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setSpigDownDownColor(Color newColor){
		SpigDownDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertFrontRightUpColor(Color newColor){
		VertFrontRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertFrontRightDownColor(Color newColor){
		VertFrontRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertFrontLeftUpColor(Color newColor){
		VertFrontLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertFrontLeftDownColor(Color newColor){
		VertFrontLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertBackRightUpColor(Color newColor){
		VertBackRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertBackRightDownColor(Color newColor){
		VertBackRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertBackLeftUpColor(Color newColor){
		VertBackLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertBackLeftDownColor(Color newColor){
		VertBackLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertLeftRightUpColor(Color newColor){
		VertLeftRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertLeftRightDownColor(Color newColor){
		VertLeftRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertLeftLeftUpColor(Color newColor){
		VertLeftLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertLeftLeftDownColor(Color newColor){
		VertLeftLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertRightRightUpColor(Color newColor){
		VertRightRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertRightRightDownColor(Color newColor){
		VertRightRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertRightLeftUpColor(Color newColor){
		VertRightLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertRightLeftDownColor(Color newColor){
		VertRightLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertUpRightUpColor(Color newColor){
		VertUpRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertUpRightDownColor(Color newColor){
		VertUpRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertUpLeftUpColor(Color newColor){
		VertUpLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertUpLeftDownColor(Color newColor){
		VertUpLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertDownRightUpColor(Color newColor){
		VertDownRightUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertDownRightDownColor(Color newColor){
		VertDownRightDown.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertDownLeftUpColor(Color newColor){
		VertDownLeftUp.GetComponent<Renderer> ().material.color = newColor;
	}

	public void setVertDownLeftDownColor(Color newColor){
		VertDownLeftDown.GetComponent<Renderer> ().material.color = newColor;
	}
}
