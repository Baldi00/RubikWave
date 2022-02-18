using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentatoreCamera : MonoBehaviour {

	protected int mSpeed = 7;
	protected ArrayList mCameraPositions = new ArrayList();
	private int mPosizione;
	private Transform mCurrentPosition;

	// Use this for initialization
	void Start () {
		mPosizione = 1;
		mCameraPositions.Add (GameObject.Find ("Posizione (1)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (2)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (3)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (4)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (5)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (6)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (7)").transform);
		mCameraPositions.Add (GameObject.Find ("Posizione (8)").transform);
	}


	void Update(){
		mPosizione = GetComponent<MovimentoCamera> ().GetPosizione ()-1;
		mCurrentPosition = (Transform) mCameraPositions [mPosizione];
	}

	void LateUpdate(){
		transform.position = Vector3.Lerp (transform.position, mCurrentPosition.position, Time.deltaTime * mSpeed);
		transform.rotation =  Quaternion.Lerp(transform.rotation, mCurrentPosition.rotation, Time.deltaTime * mSpeed);
	}

	public bool isFermo(){
		Transform actualCameraPosition = (Transform) mCameraPositions [mPosizione];
		return 
			Vector3.Distance (transform.position, actualCameraPosition.position) < 50 &&
			Quaternion.Angle (transform.rotation, actualCameraPosition.rotation) < 10;
	}

	public void ruota(){
		for(int i=0; i<8; i++){
			Transform temp = (Transform) mCameraPositions[i];
			temp.eulerAngles = new Vector3 (temp.eulerAngles.x, temp.eulerAngles.y, temp.eulerAngles.z+180);
			mCameraPositions[i] = temp;
		}
	}
}
