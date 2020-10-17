using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentatoreCamera : MonoBehaviour {

	public Transform[] m_Transforms;
	public int m_Speed;
	private int m_Posizione;
	private Transform m_CurrentTransform;

	// Use this for initialization
	void Start () {
		m_Posizione = 1;
	}


	void Update(){
		m_Posizione = GetComponent<MovimentoCamera> ().GetPosizione ()-1;
		m_CurrentTransform = m_Transforms [m_Posizione];
	}

	void LateUpdate(){
		transform.position = Vector3.Lerp (transform.position, m_CurrentTransform.position, Time.deltaTime * m_Speed);
		transform.rotation =  Quaternion.Slerp(transform.rotation, m_CurrentTransform.rotation, Time.deltaTime * m_Speed);
	}

	public bool isFermo(){
		return Vector3.Distance(transform.position, m_Transforms[m_Posizione].position) < 10;
	}

	public void ruota(){
		for(int i=0; i<8; i++){
			Transform temp = m_Transforms[i];
			temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, temp.eulerAngles.z+180);
			m_Transforms[i] = temp;
		}
	}
}
