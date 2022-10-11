using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCollidersAndHighlightManager : MonoBehaviour {
	
	protected GameObject [] mColliders;

	protected AnimationManager mAnimatore;
	protected GameManager mGameManager;
	protected InputManager mInputManager;
	protected MovimentatoreCamera mMovimentatoreCamera = null;
	protected Camera mCamera;

	protected RaycastHit mRaycastHit;

	protected List<Outline> mFrontOutline = new List<Outline>();
	protected List<Outline> mBackOutline = new List<Outline>();
	protected List<Outline> mDownOutline = new List<Outline>();
	protected List<Outline> mUpOutline = new List<Outline>();
	protected List<Outline> mLeftOutline = new List<Outline>();
	protected List<Outline> mRightOutline = new List<Outline>();

	// Use this for initialization
	void Start () {
		mColliders = GameObject.FindGameObjectsWithTag ("FaceCollider");
		mAnimatore = GameObject.Find ("GameManager").GetComponent<AnimationManager>();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
		mMovimentatoreCamera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();
		mCamera = GameObject.Find("CameraFree").GetComponent<Camera> ();

		mGameManager.SetActionPosition (0);

		FindAllOutline ();
		HideAllOutline ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mAnimatore.isFermo () && mGameManager.IsGameRunning () && mMovimentatoreCamera.isFermo ()) {
			if (mInputManager.IsLeftMousePressed ()) {
				Ray ray = mCamera.ScreenPointToRay (Input.mousePosition);
				if (Physics.Raycast (ray, out mRaycastHit, 100)) {
					string name = mRaycastHit.collider.gameObject.name;
					if (name.Equals ("FaceColliderLeft")) {
						ShowOutline (mLeftOutline);
						mGameManager.SetActionPosition (1);
					} else if (name.Equals ("FaceColliderRight")) {
						ShowOutline (mRightOutline);
						mGameManager.SetActionPosition (2);
					} else if (name.Equals ("FaceColliderFront")) {
						ShowOutline (mFrontOutline);
						mGameManager.SetActionPosition (3);
					} else if (name.Equals ("FaceColliderBack")) {
						ShowOutline (mBackOutline);
						mGameManager.SetActionPosition (4);
					} else if (name.Equals ("FaceColliderUp")) {
						ShowOutline (mUpOutline);
						mGameManager.SetActionPosition (5);
					} else if (name.Equals ("FaceColliderDown")) {
						ShowOutline (mDownOutline);
						mGameManager.SetActionPosition (6);
					}
				} else {
					HideAllOutline ();
					mGameManager.SetActionPosition (0);
				}
			}
		}
	}

	void FindAllOutline () {
		mFrontOutline.Add (GameObject.Find ("Cubo/Centrale/Cent1/Corpo").GetComponent<Outline> ());
		mLeftOutline.Add (GameObject.Find ("Cubo/Centrale/Cent2/Corpo").GetComponent<Outline> ());
		mRightOutline.Add (GameObject.Find ("Cubo/Centrale/Cent3/Corpo").GetComponent<Outline> ());
		mBackOutline.Add (GameObject.Find ("Cubo/Centrale/Cent4/Corpo").GetComponent<Outline> ());
		mUpOutline.Add (GameObject.Find ("Cubo/Centrale/Cent5/Corpo").GetComponent<Outline> ());
		mDownOutline.Add (GameObject.Find ("Cubo/Centrale/Cent6/Corpo").GetComponent<Outline> ());

		Outline temp = GameObject.Find ("Cubo/Spigolo/Spig1/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mUpOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig2/Corpo").GetComponent<Outline> ();
		mLeftOutline.Add (temp);
		mFrontOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig3/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mRightOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig4/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mDownOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig5/Corpo").GetComponent<Outline> ();
		mLeftOutline.Add (temp);
		mUpOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig6/Corpo").GetComponent<Outline> ();
		mLeftOutline.Add (temp);
		mBackOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig7/Corpo").GetComponent<Outline> ();
		mLeftOutline.Add (temp);
		mDownOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig8/Corpo").GetComponent<Outline> ();
		mRightOutline.Add (temp);
		mUpOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig9/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mRightOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig10/Corpo").GetComponent<Outline> ();
		mRightOutline.Add (temp);
		mDownOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig11/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mUpOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Spigolo/Spig12/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mDownOutline.Add (temp);

		temp = GameObject.Find ("Cubo/Vertice/Vert1/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mUpOutline.Add (temp);
		mLeftOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert2/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mUpOutline.Add (temp);
		mRightOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert3/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mDownOutline.Add (temp);
		mLeftOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert4/Corpo").GetComponent<Outline> ();
		mFrontOutline.Add (temp);
		mDownOutline.Add (temp);
		mRightOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert5/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mUpOutline.Add (temp);
		mLeftOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert6/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mUpOutline.Add (temp);
		mRightOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert7/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mDownOutline.Add (temp);
		mLeftOutline.Add (temp);
		temp = GameObject.Find ("Cubo/Vertice/Vert8/Corpo").GetComponent<Outline> ();
		mBackOutline.Add (temp);
		mDownOutline.Add (temp);
		mRightOutline.Add (temp);
	}

	void HideAllOutline(){
		for (int i = 0; i < mFrontOutline.Count; i++) {
			mFrontOutline [i].enabled = false;
			mBackOutline [i].enabled = false;
			mLeftOutline [i].enabled = false;
			mRightOutline [i].enabled = false;
			mUpOutline [i].enabled = false;
			mDownOutline [i].enabled = false;
		}
	}

	void ShowOutline(List<Outline> toShow){
		HideAllOutline ();
		for (int i = 0; i < toShow.Count; i++) {
			toShow [i].enabled = true;
		}
	}
}
