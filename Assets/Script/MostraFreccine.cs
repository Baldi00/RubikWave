using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MostraFreccine : MonoBehaviour {

	[SerializeField]
	private GameObject m_Front,m_Back,m_Left,m_Right,m_Up,m_Down;

	[SerializeField]
	private MovimentoCamera m_Camera;
	
	// Update is called once per frame
	void Update () {
		if (m_Camera.GetPosizione () == 1 || m_Camera.GetPosizione () == 4 || m_Camera.GetPosizione () == 5 || m_Camera.GetPosizione () == 8)
			m_Front.SetActive (true);
		else
			m_Front.SetActive (false);
		
		if (m_Camera.GetPosizione () == 2 || m_Camera.GetPosizione () == 3 || m_Camera.GetPosizione () == 6 || m_Camera.GetPosizione () == 7)
			m_Back.SetActive(true);
		else
			m_Back.SetActive (false);
		
		if (m_Camera.GetPosizione () == 1 || m_Camera.GetPosizione () == 2 || m_Camera.GetPosizione () == 5 || m_Camera.GetPosizione () == 6)
			m_Left.SetActive(true);
		else
			m_Left.SetActive (false);
		
		if (m_Camera.GetPosizione () == 3 || m_Camera.GetPosizione () == 4 || m_Camera.GetPosizione () == 7 || m_Camera.GetPosizione () == 8)
			m_Right.SetActive(true);
		else
			m_Right.SetActive (false);
		
		if (m_Camera.GetPosizione () == 1 || m_Camera.GetPosizione () == 2 || m_Camera.GetPosizione () == 3 || m_Camera.GetPosizione () == 4)
			m_Up.SetActive(true);
		else
			m_Up.SetActive (false);
		
		if (m_Camera.GetPosizione () == 5 || m_Camera.GetPosizione () == 6 || m_Camera.GetPosizione () == 7 || m_Camera.GetPosizione () == 8)
			m_Down.SetActive(true);
		else
			m_Down.SetActive (false);
	}
}
