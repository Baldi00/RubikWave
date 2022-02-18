using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeCollidersManager : MonoBehaviour {

	protected GameObject [] mColliders;

	protected Animatore mAnimatore;
	protected GameManager mGameManager;
	protected InputManager mInputManager;
	protected ActionManager mActionManager;
	protected MovimentatoreCamera mCamera = null;
	protected Camera mUICamera;

	protected RaycastHit2D [] mRaycastHitsStart;
	protected RaycastHit2D [] mRaycastHitsEnd;
	protected Vector3 mStartPosition, mEndPosition;

	// Use this for initialization
	void Start () {
		mColliders = GameObject.FindGameObjectsWithTag ("SwipeCollider");
		mAnimatore = GameObject.Find ("Animazioni").GetComponent<Animatore>();
		mGameManager = GameObject.Find("GameManager").GetComponent<GameManager> ();
		mInputManager = GameObject.Find("GameManager").GetComponent<InputManager> ();
		mCamera = GameObject.Find ("CameraFree").GetComponent<MovimentatoreCamera>();
		mActionManager = GameObject.Find("GameManager").GetComponent<ActionManager> ();
		mUICamera = GameObject.Find("UICamera").GetComponent<Camera> ();

		mStartPosition = new Vector3 (-1f, -1f);
		mEndPosition = new Vector3 (-1f, -1f);
	}
	
	// Update is called once per frame
	void Update () {
		if (mAnimatore.isFermo () && mGameManager.IsGameRunning () && mCamera.isFermo ()) {
			if (mGameManager.GetCameraPosition () < 5) {
				if (mGameManager.IsCameraRotated ()) {
					ShowReverseColliders ();
				} else {
					ShowStraightColliders ();
				}
			} else {
				if (mGameManager.IsCameraRotated ()) {
					ShowStraightColliders ();
				} else {
					ShowReverseColliders ();
				}
			}

			if (mInputManager.IsLeftMousePressed ()) {
				Ray ray = mUICamera.ScreenPointToRay (Input.mousePosition);
				mRaycastHitsStart = Physics2D.RaycastAll (new Vector2(ray.GetPoint(1).x, ray.GetPoint(1).y), new Vector2(ray.direction.x, ray.direction.y));
				mStartPosition = Input.mousePosition;
			}
			if (mInputManager.IsLeftMouseReleased ()) {
				Ray ray = mUICamera.ScreenPointToRay (Input.mousePosition);
				mRaycastHitsEnd = Physics2D.RaycastAll (new Vector2(ray.GetPoint(1).x, ray.GetPoint(1).y), new Vector2(ray.direction.x, ray.direction.y));
				mEndPosition = Input.mousePosition;
			}

			if (mStartPosition.x != -1f && mEndPosition.x != -1f && mInputManager.IsLeftMouseReleased ()) {
				bool found = false;
				string name = null;
				for (int i = 0; i < mRaycastHitsStart.Length && !found; i++) {
					string name1 = mRaycastHitsStart [i].collider.gameObject.name;
					for (int j = 0; j < mRaycastHitsEnd.Length && !found; j++) {
						string name2 = mRaycastHitsEnd [j].collider.gameObject.name;
						if (name1.Equals (name2)) {
							name = name1;
							found = true;
						}
					}
				}

				if(found)
					mActionManager.CalculateActionToPerform (mStartPosition, mEndPosition, name);

				mStartPosition = new Vector3 (-1f, -1f);
				mEndPosition = new Vector3 (-1f, -1f);
			}

		} else {
			HideAllColliders ();
		}
	}

	public void HideAllColliders(){
		for (int i = 0; i < mColliders.Length; i++) {
			mColliders [i].SetActive (false);
		}
	}

	public void ShowReverseColliders(){
		HideAllColliders ();
		for (int i = 0; i < mColliders.Length; i++) {
			if(mColliders[i].gameObject.name.Contains("Reverse"))
				mColliders [i].SetActive (true);
		}
	}

	public void ShowStraightColliders(){
		HideAllColliders ();
		for (int i = 0; i < mColliders.Length; i++) {
			if(!mColliders[i].gameObject.name.Contains("Reverse"))
				mColliders [i].SetActive (true);
		}
	}
}
